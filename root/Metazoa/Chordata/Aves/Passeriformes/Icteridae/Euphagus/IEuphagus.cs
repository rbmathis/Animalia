namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Euphagus;

/// <summary>
/// Interface defining characteristics of Euphagus (genus).
/// </summary>
public interface IEuphagus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
