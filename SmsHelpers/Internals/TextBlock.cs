﻿namespace Texting.Internals
{
    /// <summary>
    ///   Class to store URLs, individual words etc.
    /// </summary>
    internal class TextBlock
    {
        public string Content { get; set; }
        public int Length { get; set; }
        public bool IsLink { get; }

        public TextBlock()
        {
        }

        public TextBlock(string text)
        {
            Content = text;
        }

        public TextBlock(string text, bool isLink)
        {
            Content = text;
            IsLink = isLink;
        }
    }
}
