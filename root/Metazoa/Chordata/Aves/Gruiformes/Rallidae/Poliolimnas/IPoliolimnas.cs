namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Poliolimnas;

/// <summary>
/// Interface defining characteristics of Poliolimnas (genus).
/// </summary>
public interface IPoliolimnas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
