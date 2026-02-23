namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Tachyoryctes;

/// <summary>
/// Interface defining characteristics of Tachyoryctes (genus).
/// </summary>
public interface ITachyoryctes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
