namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Chloropicus;

/// <summary>
/// Interface defining characteristics of Chloropicus (genus).
/// </summary>
public interface IChloropicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
