﻿using TheresaBot.Main.Type;

namespace TheresaBot.Main.Model.VO
{
    public record DictionaryVo
    {
        public int Id { get; set; }

        public string Words { get; set; }

        public long CreateAt { get; set; }

        public DictionaryType WordType { get; set; }

        public int SubType { get; set; }


    }
}
