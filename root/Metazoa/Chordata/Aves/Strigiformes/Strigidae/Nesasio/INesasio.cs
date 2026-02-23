namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Nesasio;

/// <summary>
/// Interface defining characteristics of Nesasio (genus).
/// </summary>
public interface INesasio
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
