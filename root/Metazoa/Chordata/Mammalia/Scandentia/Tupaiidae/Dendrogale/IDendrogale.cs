namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae.Dendrogale;

/// <summary>
/// Interface defining characteristics of Dendrogale (genus).
/// </summary>
public interface IDendrogale
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
