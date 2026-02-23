namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Neopagetopsis;

/// <summary>
/// Interface defining characteristics of Neopagetopsis (genus).
/// </summary>
public interface INeopagetopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
