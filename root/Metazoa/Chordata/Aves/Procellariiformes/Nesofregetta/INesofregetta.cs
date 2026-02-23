namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Nesofregetta;

/// <summary>
/// Interface defining characteristics of Nesofregetta (genus).
/// </summary>
public interface INesofregetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
