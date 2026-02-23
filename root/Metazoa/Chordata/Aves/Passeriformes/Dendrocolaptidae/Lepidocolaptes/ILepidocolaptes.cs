namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Lepidocolaptes;

/// <summary>
/// Interface defining characteristics of Lepidocolaptes (genus).
/// </summary>
public interface ILepidocolaptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
