namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Onychognathus;

/// <summary>
/// Interface defining characteristics of Onychognathus (genus).
/// </summary>
public interface IOnychognathus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
