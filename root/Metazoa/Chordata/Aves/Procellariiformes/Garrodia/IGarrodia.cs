namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Garrodia;

/// <summary>
/// Interface defining characteristics of Garrodia (genus).
/// </summary>
public interface IGarrodia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
