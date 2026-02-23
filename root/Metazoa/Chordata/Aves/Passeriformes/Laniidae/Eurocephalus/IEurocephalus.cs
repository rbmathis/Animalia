namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae.Eurocephalus;

/// <summary>
/// Interface defining characteristics of Eurocephalus (genus).
/// </summary>
public interface IEurocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
