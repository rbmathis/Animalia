namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Lepidothrix;

/// <summary>
/// Interface defining characteristics of Lepidothrix (genus).
/// </summary>
public interface ILepidothrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
