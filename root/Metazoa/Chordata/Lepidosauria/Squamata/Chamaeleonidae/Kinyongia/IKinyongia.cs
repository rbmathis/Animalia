namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Kinyongia;

/// <summary>
/// Interface defining characteristics of Kinyongia (genus).
/// </summary>
public interface IKinyongia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
