namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Chrysomus;

/// <summary>
/// Interface defining characteristics of Chrysomus (genus).
/// </summary>
public interface IChrysomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
