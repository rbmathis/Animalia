namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Piculus;

/// <summary>
/// Interface defining characteristics of Piculus (genus).
/// </summary>
public interface IPiculus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
