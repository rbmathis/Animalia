namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Phoenicolacerta;

/// <summary>
/// Interface defining characteristics of Phoenicolacerta (genus).
/// </summary>
public interface IPhoenicolacerta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
