%% 16 Bit CRC Code
% Thomas Calloway
% 16.548 - Assignment #2
% Spring 2011

%% Code for the CRC-16 Implementation and Test
function CRC()
    % Create 96 value input vector (bits)
    inputMsg = zeros(96,1);
    for i=1:96
       if mod(i,2) == 0
           inputMsg(i) = 1;
       end
    end
    
    results = sprintf('Input Message: ');
    for i=1:size(inputMsg,1)
        results = [results num2str(inputMsg(i))];
    end
    results = [results sprintf('\r\n\n\r')];

    % Calculate and append a 16 bit CRC
    augMsg = inputMsg; augMsg(97:112) = zeros(16,1);
    crcReg = CalculateCRC(augMsg, 112);

    results = [results 'Part A: CRC: ' ];
    for i=1:16
        results = [results, num2str(crcReg(i))];
    end
    results = [results sprintf('\r\n')];

    % Compute CRC on all 112 bits and verify result is zero
    augMsg = inputMsg; 
    augMsg(97:112) = crcReg(1:16);
    crcTest = CalculateCRC(augMsg, 112);
    
    results = [results 'Part B: CRC Verification: ' ];
    for i=1:16
        results = [results num2str(crcTest(i))];
    end
    results = [results sprintf('\r\n')];
    
    % Try again with bits 9-16 incorrect
    augMsg = inputMsg; augMsg(97:112) = crcReg(1:16);
    augMsg(9:16) = ~augMsg(9:16);
    crcTest = CalculateCRC(augMsg, 112);
    
    results = [results 'Part C: CRC Verification (9-16 errors): ' ];
    for i=1:16
        results = [results num2str(crcTest(i))];
    end
    results = [results sprintf('\r\n')];
    
    % Try again with value 1 for last 8 bits
    augMsg = inputMsg; augMsg(97:112) = crcReg(1:16);
    augMsg(105:112) = ones(1,8);
    crcTest = CalculateCRC(augMsg, 112);
    
    results = [results 'Part D: CRC Verification (last 8 bits 1): ' ];
    for i=1:16
        results = [results num2str(crcTest(i))];
    end
    results = [results sprintf('\r\n')];
    
    % Try again with bits 8,16,24,32,100
    augMsg = inputMsg; augMsg(97:112) = crcReg(1:16);
    augMsg(8) = ~augMsg(8); augMsg(16) = ~augMsg(16);
    augMsg(24) = ~augMsg(24); augMsg(32) = ~augMsg(32);
    augMsg(100) = ~augMsg(100);
    crcTest = CalculateCRC(augMsg, 112);
    
    results = [results 'Part E: CRC Verification (misc. errors): ' ];
    for i=1:16
        results = [results num2str(crcTest(i))];
    end
    results = [results sprintf('\r\n')];
    
    % File Output
    outFile = fopen('results.txt', 'w');
    fprintf(outFile, '%s', results);
    fclose(outFile);
    
    % Command Window Output
    results
    pause(5); clc;
end

function crcReg = CalculateCRC(augMsg, msgLen)
    % CRC-16 G(x) = x16 + x15 + x2 + 1
    genX =   [1 1 0 0 0 0 0 0 0 0 0 0 0 0 1 0 1];
    crcReg = [0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0];
    
    for i=1:msgLen
        regPop = crcReg(1); % Save popped bit for later
        crcReg(1:15) = crcReg(2:16); % Shift one bit
        crcReg(16) = augMsg(i);

        if regPop == 1
            crcReg = bitxor(crcReg(1:16),genX(1:16));
        end
    end
end
