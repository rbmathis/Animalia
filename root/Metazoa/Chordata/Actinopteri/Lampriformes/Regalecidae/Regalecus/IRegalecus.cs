namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Regalecidae.Regalecus;

/// <summary>
/// Interface defining characteristics of Regalecus (genus).
/// </summary>
public interface IRegalecus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
