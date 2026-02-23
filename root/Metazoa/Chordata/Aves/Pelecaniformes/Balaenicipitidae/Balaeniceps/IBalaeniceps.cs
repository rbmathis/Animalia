namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Balaenicipitidae.Balaeniceps;

/// <summary>
/// Interface defining characteristics of Balaeniceps (genus).
/// </summary>
public interface IBalaeniceps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
