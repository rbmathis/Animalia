namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Gasterosteus;

/// <summary>
/// Interface defining characteristics of Gasterosteus (genus).
/// </summary>
public interface IGasterosteus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
