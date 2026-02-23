namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Pelagodroma;

/// <summary>
/// Interface defining characteristics of Pelagodroma (genus).
/// </summary>
public interface IPelagodroma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
