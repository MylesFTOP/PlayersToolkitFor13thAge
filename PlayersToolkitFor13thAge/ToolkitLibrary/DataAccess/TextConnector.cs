﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolkitLibrary.DataAccess.TextHelpers;

namespace ToolkitLibrary
{
    public class TextConnector : IDataConnection
    {
        private const string CharactersFile = "CharacterModels.csv";
        public CharacterModel SaveCharacter(CharacterModel model) {
            // Load the text file and convert the text to a list<CharacterModel>
            List<CharacterModel> characters = CharactersFile
                .FullFilePath()
                .LoadFile()
                .ConvertToCharacterModels();

            // Find max ID
            int currentId = 1;

            if ( characters.Count > 0 )
            {
                currentId = characters
                    .OrderByDescending(x => x.CharacterId)
                    .First()
                    .CharacterId + 1;
            }
            model.CharacterId = currentId;

            // Add the new record with the new ID (max + 1)
            characters.Add(model);

            // Convert the character to a list<string> and save the list<string> to the text file
            characters.SaveToCharactersFile(CharactersFile);

            return model;
        }
    }
}
