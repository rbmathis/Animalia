namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Micropternus;

/// <summary>
/// Interface defining characteristics of Micropternus (genus).
/// </summary>
public interface IMicropternus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
