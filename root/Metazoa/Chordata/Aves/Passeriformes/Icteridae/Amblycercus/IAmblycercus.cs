namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Amblycercus;

/// <summary>
/// Interface defining characteristics of Amblycercus (genus).
/// </summary>
public interface IAmblycercus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
