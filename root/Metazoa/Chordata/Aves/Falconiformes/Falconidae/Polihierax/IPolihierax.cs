namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Polihierax;

/// <summary>
/// Interface defining characteristics of Polihierax (genus).
/// </summary>
public interface IPolihierax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
