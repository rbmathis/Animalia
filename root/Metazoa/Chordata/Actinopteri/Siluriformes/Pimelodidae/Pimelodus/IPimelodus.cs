namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pimelodus;

/// <summary>
/// Interface defining characteristics of Pimelodus (genus).
/// </summary>
public interface IPimelodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
