namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Oceanites;

/// <summary>
/// Interface defining characteristics of Oceanites (genus).
/// </summary>
public interface IOceanites
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
