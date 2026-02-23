namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Passerculus;

/// <summary>
/// Interface defining characteristics of Passerculus (genus).
/// </summary>
public interface IPasserculus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
