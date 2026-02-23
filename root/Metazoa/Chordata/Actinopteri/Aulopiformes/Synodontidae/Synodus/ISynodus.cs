namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Synodus;

/// <summary>
/// Interface defining characteristics of Synodus (genus).
/// </summary>
public interface ISynodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
