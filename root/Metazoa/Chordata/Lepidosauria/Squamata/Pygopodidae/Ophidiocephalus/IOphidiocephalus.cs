namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae.Ophidiocephalus;

/// <summary>
/// Interface defining characteristics of Ophidiocephalus (genus).
/// </summary>
public interface IOphidiocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
