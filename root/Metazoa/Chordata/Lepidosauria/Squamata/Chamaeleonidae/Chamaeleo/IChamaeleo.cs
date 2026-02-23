namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Chamaeleo;

/// <summary>
/// Interface defining characteristics of Chamaeleo (genus).
/// </summary>
public interface IChamaeleo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
