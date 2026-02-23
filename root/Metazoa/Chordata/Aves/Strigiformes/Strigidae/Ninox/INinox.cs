namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Ninox;

/// <summary>
/// Interface defining characteristics of Ninox (genus).
/// </summary>
public interface INinox
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
