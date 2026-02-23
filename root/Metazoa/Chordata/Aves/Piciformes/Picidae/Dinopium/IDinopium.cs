namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dinopium;

/// <summary>
/// Interface defining characteristics of Dinopium (genus).
/// </summary>
public interface IDinopium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
