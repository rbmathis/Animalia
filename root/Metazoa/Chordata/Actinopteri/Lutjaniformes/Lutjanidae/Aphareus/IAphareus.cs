namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Aphareus;

/// <summary>
/// Interface defining characteristics of Aphareus (genus).
/// </summary>
public interface IAphareus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
