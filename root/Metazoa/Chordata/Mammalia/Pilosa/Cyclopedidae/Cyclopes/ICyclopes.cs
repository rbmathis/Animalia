namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Cyclopedidae.Cyclopes;

/// <summary>
/// Interface defining characteristics of Cyclopes (genus).
/// </summary>
public interface ICyclopes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
