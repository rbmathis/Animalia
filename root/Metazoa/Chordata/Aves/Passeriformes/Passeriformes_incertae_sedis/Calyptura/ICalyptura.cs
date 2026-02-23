namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis.Calyptura;

/// <summary>
/// Interface defining characteristics of Calyptura (genus).
/// </summary>
public interface ICalyptura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
