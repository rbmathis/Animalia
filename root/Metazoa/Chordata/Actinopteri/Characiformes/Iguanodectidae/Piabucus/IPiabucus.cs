namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae.Piabucus;

/// <summary>
/// Interface defining characteristics of Piabucus (genus).
/// </summary>
public interface IPiabucus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
