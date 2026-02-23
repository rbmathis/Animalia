namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Acentronura;

/// <summary>
/// Interface defining characteristics of Acentronura (genus).
/// </summary>
public interface IAcentronura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
