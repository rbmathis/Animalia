namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Anumara;

/// <summary>
/// Interface defining characteristics of Anumara (genus).
/// </summary>
public interface IAnumara
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
