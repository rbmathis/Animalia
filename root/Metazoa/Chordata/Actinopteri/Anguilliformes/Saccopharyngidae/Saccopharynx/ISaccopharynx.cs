namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Saccopharyngidae.Saccopharynx;

/// <summary>
/// Interface defining characteristics of Saccopharynx (genus).
/// </summary>
public interface ISaccopharynx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
