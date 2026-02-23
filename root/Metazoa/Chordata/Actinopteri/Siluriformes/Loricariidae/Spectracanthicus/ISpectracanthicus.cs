namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Spectracanthicus;

/// <summary>
/// Interface defining characteristics of Spectracanthicus (genus).
/// </summary>
public interface ISpectracanthicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
