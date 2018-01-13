function p3()
    n = 30e3; nBlock = 1e3;

    % Data message creation [1 1 0 1 1];
    dMessage = randint(1,n,[0 1]);
    dMessageBPSK = dMessage;

    % Encode the message
    dEncoded = encoder(dMessage, [0 0 0]);
    
    SNR=[3 6 9];
    bitErrorRateBPSK=zeros(1,length(SNR));
    bitErrorRateHard=zeros(1,length(SNR));
    bitErrorRateSoft=zeros(1,length(SNR));
    
    % Force to +1 and -1 (BPSK)
    dMessageBPSK = forcePlusMinusOne(dMessageBPSK);
    
    % Add noise to the signal (Hard & Soft QPSK)
    dTx = zeros(2, length(dMessage), length(SNR));
    for i=1:length(SNR)
        dTx(:, : ,i) = addAWGN(dEncoded,SNR(i));
    end
    
    % Uncoded BPSK
    for i=1:length(SNR)
        % Add noise to the signal
        dDecoded = awgn(dMessageBPSK,SNR(i));
        
        % Force to +1 and -1 (hard decision)
        dDecoded = forcePlusMinusOne(dDecoded);
                
        % Calculate the bit error rate
        bitError=0;
        for j=1:length(dMessage)
            if (dMessageBPSK(j) ~= dDecoded(j))
                bitError = bitError + 1;
            end
        end
        bitErrorRateBPSK(i)= bitError / length(dDecoded);
    end
    
%     % Hard decision
%     for i=1:length(SNR)
%         % Decode the noisy signal in blocks
%         for j=1:(length(dMessage)/nBlock)
%             dDecoded(j*nBlock-nBlock+1:j*nBlock) = decoder(dTx(:,j*nBlock-nBlock+1:j*nBlock, i), 0);
%         end
%         
%         % Calculate the bit error rate
%         bitError=0;
%         for j=1:length(dMessage)
%             if (dMessage(j) ~= dDecoded(j))
%                 bitError = bitError + 1;
%             end
%         end
%         bitErrorRateHard(i)= bitError / length(dTx);
%     end
    
    % Soft decision
    for i=1:length(SNR)
        % Decode the noisy signal in blocks
        for j=1:(length(dMessage)/nBlock)
            dDecoded(j*nBlock-nBlock+1:j*nBlock) = decoder(dTx(:,j*nBlock-nBlock+1:j*nBlock, i), 1);
        end
        
        % Calculate the bit error rate
        bitError=0;
        for j=1:length(dMessage)
            if (dMessage(j) ~= dDecoded(j))
                bitError = bitError + 1;
            end
        end
        bitErrorRateSoft(i)= bitError / length(dTx);
    end
    
    semilogy(SNR, bitErrorRateBPSK, 'r*'); hold on;
%     semilogy(SNR, bitErrorRateHard, 'g*'); hold on;
    semilogy(SNR, bitErrorRateSoft, 'b*'); hold on;
    legend('BPSK', 'Soft Decision');
    
    xlim([2 10]); ylim([10^-6 1]);
    xlabel('SNR'); ylabel('Bit Error Probability');
    title( sprintf( 'Waterfall Plot (MSG: %d Bits, Blocks: %d bits)', n , nBlock) );
    
    % Print results
    SNR
    bitErrorRateBPSK
%     bitErrorRateHard
    bitErrorRateSoft
end

function out = forcePlusMinusOne(in)
    out = in;

    for j=1:length(in)
       if (in(j) <= 0)
           out(j) = -1;
       else
           out(j) = 1;
       end
    end
end

function dTx = addAWGN(dEncoded, SNR)
    % Convert 0's and +1's to -1's and +1's
    for i=1:length(dEncoded)
       if (dEncoded(1,i) == 0)
           dEncoded(1,i) = -1;
       end
       
       if (dEncoded(2,i) == 0)
           dEncoded(2,i) = -1; 
       end
    end

    % Add noise to deconstructed message
    dTx = awgn(dEncoded, SNR);
end