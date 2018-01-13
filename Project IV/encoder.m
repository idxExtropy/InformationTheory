function outData = encoder(inData, reg)
    outData = zeros(2,length(inData));

    for i=1:length(inData)
        % Update the register
        reg(3) = reg(2);
        reg(2) = reg(1);
        reg(1) = inData(i);
        
        % Calculate output bits
        u1 = xor(xor(reg(1),reg(2)),reg(3));
        u2 = xor(reg(1),reg(3));
        
        if (u1 == 0)
            outData(1, i) = -1;
        else
            outData(1, i) = 1;
        end
        
        if (u2 == 0)
            outData(2, i) = -1;
        else
            outData(2, i) = 1;
        end
    end
end