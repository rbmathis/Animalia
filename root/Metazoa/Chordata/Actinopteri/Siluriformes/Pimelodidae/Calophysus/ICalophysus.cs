namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Calophysus;

/// <summary>
/// Interface defining characteristics of Calophysus (genus).
/// </summary>
public interface ICalophysus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
