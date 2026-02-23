namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Oceanodroma;

/// <summary>
/// Interface defining characteristics of Oceanodroma (genus).
/// </summary>
public interface IOceanodroma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
