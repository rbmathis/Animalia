namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Dryolimnas;

/// <summary>
/// Interface defining characteristics of Dryolimnas (genus).
/// </summary>
public interface IDryolimnas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
