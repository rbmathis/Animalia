namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Xenoglaux;

/// <summary>
/// Interface defining characteristics of Xenoglaux (genus).
/// </summary>
public interface IXenoglaux
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
