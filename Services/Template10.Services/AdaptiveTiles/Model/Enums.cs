﻿namespace Template10.Services.AdaptiveTiles.Model
{
    public enum TextHintAlign
    {
        Left,
        Center,
        Right
    }

    public enum VisualHintPresentation
    {
        Photos,
        People,
        Contact
    }

    public enum VisualHintTextStacking
    {
        Top,
        Center,
        Bottom
    }

    public enum TextStyle
    {
        Caption,
        CaptionSubtle,
        Body,
        BodySubtle,
        Base, // allows using a reserved word in an enum
        BaseSubtle,
        Subtitle,
        SubtitleSubtle,
        Title,
        TitleSubtle,
        TitleNumeral,
        Subheader,
        SubheaderSubtle,
        SubHeaderNumeral,
        Header,
        HeaderSubtle,
        HeaderNumber
    }

    public enum SubGroupTextStacking
    {
        Top,
        Center,
        Bottom
    }

    public enum ImagePlacement
    {
        Inline,
        Background,
        Peek
    }

    public enum ImageHintAlign
    {
        Stretch,
        Left,
        Center,
        Right
    }
}