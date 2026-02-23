namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Amblyramphus;

/// <summary>
/// Interface defining characteristics of Amblyramphus (genus).
/// </summary>
public interface IAmblyramphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
