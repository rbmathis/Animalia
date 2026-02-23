namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Leptonycteris;

/// <summary>
/// Interface defining characteristics of Leptonycteris (genus).
/// </summary>
public interface ILeptonycteris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
