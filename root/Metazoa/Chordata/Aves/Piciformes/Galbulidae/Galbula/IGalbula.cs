namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Galbulidae.Galbula;

/// <summary>
/// Interface defining characteristics of Galbula (genus).
/// </summary>
public interface IGalbula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
