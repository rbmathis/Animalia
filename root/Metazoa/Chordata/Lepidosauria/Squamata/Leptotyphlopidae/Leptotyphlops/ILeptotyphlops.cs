namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Leptotyphlops;

/// <summary>
/// Interface defining characteristics of Leptotyphlops (genus).
/// </summary>
public interface ILeptotyphlops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
