﻿using PuzzleImageGenerator.Shared;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Mega
{
    public class MegaImageConfiguration : ImageConfiguration
    {
        public string Scheme { get; private set; }

        public MegaImageConfiguration(IDictionary<string, string> commands)
            : base(commands)
        {
            foreach (var command in commands)
            {
                switch (command.Key)
                {
                    case "scheme":
                        Scheme = command.Value;
                        break;
                }
            }
        }
    }
}