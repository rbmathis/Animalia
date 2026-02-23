namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Girellidae.Girella;

/// <summary>
/// Interface defining characteristics of Girella (genus).
/// </summary>
public interface IGirella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
