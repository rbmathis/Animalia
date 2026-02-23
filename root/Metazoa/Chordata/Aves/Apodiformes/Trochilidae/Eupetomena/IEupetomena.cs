namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Eupetomena;

/// <summary>
/// Interface defining characteristics of Eupetomena (genus).
/// </summary>
public interface IEupetomena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
