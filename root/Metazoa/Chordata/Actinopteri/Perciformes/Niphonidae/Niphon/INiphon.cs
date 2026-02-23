namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Niphonidae.Niphon;

/// <summary>
/// Interface defining characteristics of Niphon (genus).
/// </summary>
public interface INiphon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
