%% Take Home Exercise II: Filter Bears
% Thomas Calloway, ID# 00439618
% Communication Theory, Fall 2010 
% Professor Jay Weitzen

clear all; close all;

% PART 1: create time axis and pulse
t=1:300; pulse=[ones(1,100) zeros(1,200)];

% PART 2: Create 3 filter candidates
baby=[ones(1,50) zeros(1,250)];
mama=[ones(1,100) zeros(1,200)];
papa=[ones(1,200) zeros(1,100)];

figure(1); 
subplot(2,2,1); plot(t,pulse); title('Pulse'); axis([0 300 0 1.2]);
subplot(2,2,2); plot(t,baby); title('Baby Filter'); axis([0 300 0 1.2]);
subplot(2,2,3); plot(t,mama); title('Mama Filter'); axis([0 300 0 1.2]);
subplot(2,2,4); plot(t,papa); title('Papa Filter'); axis([0 300 0 1.2]);

% PART 3: Noise variance
figure(2); x=ones(1,1e6); noise=awgn(x,15);
subplot(2,2,1); plot(1:1e6,noise); title('Noise (AWGN)');

inputVarBaby=var(noise);
out=conv(baby,noise);
outputVarBaby=var(out(1:1e6));
subplot(2,2,2);  plot(out); title('Baby Noise');

inputVarMama=var(noise);
out=conv(mama,noise);
outputVarMama=var(out(1:1e6));
subplot(2,2,3);  plot(out); title('Mama Noise');

inputVarPapa=var(noise);
out=conv(papa,noise);
outputVarPapa=var(out(1:1e6));
subplot(2,2,4);  plot(out); title('Papa Noise');

figure(3); hist(out,1000); title('Output Histogram (Papa Filter)'); 
axis([190 210 0 4e4]);

% PART 4: Convolve with the target pulse
babyFilt=conv(pulse,baby); snrBaby=(max(babyFilt)^2)/outputVarBaby
mamaFilt=conv(pulse,mama); snrMama=(max(mamaFilt)^2)/outputVarMama
papaFilt=conv(pulse,papa); snrPapa=(max(papaFilt)^2)/outputVarPapa

figure(4);
subplot(2,2,1); plot(pulse); title('Input Signal Pulse');
subplot(2,2,2); plot(babyFilt); title('Baby Filtered');
subplot(2,2,3); plot(mamaFilt); title('Mama Filtered');
subplot(2,2,4); plot(papaFilt); title('Papa Filtered');

% PART 5: Calculate the SNR theoretically
% Calculations performed separately (by hand)

figure(5); noisePulse=[awgn(ones(1,100),15) zeros(1,200)];
subplot(2,2,1); plot(noisePulse); title('Input Signal');
subplot(2,2,2); plot(babyFilt); title('Baby Filtered');
subplot(2,2,3); plot(mamaFilt); title('Mama Filtered');
subplot(2,2,4); plot(papaFilt); title('Papa Filtered');

% PART 6: Create 10e6 random plus and minus 1s
n=10e4; txSignal=randint(1,n,[-1 1]); % to become 10e6 samples

figure(6);
stairs(txSignal); title('Input Data Signal'); axis([0 100 0 1.1]);

% PART 7: Calculate bit error for various SNRs
bitErrorRate=zeros(1,8); SNR=[3 6 7 8 9 10 11 12];
for i=1:8,
    rxDeciphered=round(awgn(txSignal,SNR(i))); bitError=0;
    for j=1:n,
        if (txSignal(j)~=rxDeciphered(j))
            bitError = bitError + 1;
        end
    end
    bitErrorRate(i)=bitError/n;
end

snrValues = 10.^(SNR./10);

figure(7);
plot(SNR,log10(bitErrorRate), 'r*'); hold on;
plot(SNR, qfunc(sqrt(snrValues)), 'g*');
legend('log10(Bit Error Rate)', 'Q(sqrt(SNR))', 'Location', 'SouthWest');
xlabel('SNR'); title('Waterfall Plot');

% PART 8: Two random streams
n = 10e3; noise1 = randn(n,1); noise2=randn(n,1);

stream1H = abs(3*sign(randn(n,1))) + noise1;
stream1L = -abs(3*sign(randn(n,1))) + noise1;
stream2H = abs(3*sign(randn(n,1))) + noise2;
stream2L = -abs(3*sign(randn(n,1))) + noise2;

figure(8); 
plot(stream1H,stream2H,'ro'); hold on;
plot(stream1L,stream2L,'go');
plot(stream1H,stream2L,'co');
plot(stream1L,stream2H,'mo');
title('+/- 3V Logic Streams with Noise');
xlabel('Volts'); ylabel('Volts');