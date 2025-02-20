﻿using Words;
public class coralCipher : cipherBase
{
    protected override string Name { get { return "Coral"; } }

    static int moduleIdCounter = 1;

    protected override void Initialize()
    {
        moduleId = moduleIdCounter++;
        answer = new Data().PickWord(6);
        Log("CORAL", "Generated Word: {0}", answer);
        pages = coralcipher(answer);
    }
}
