namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anniellidae.Anniella;

/// <summary>
/// Interface defining characteristics of Anniella (genus).
/// </summary>
public interface IAnniella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
