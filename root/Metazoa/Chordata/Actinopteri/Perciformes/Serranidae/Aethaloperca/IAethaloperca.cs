namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Aethaloperca;

/// <summary>
/// Interface defining characteristics of Aethaloperca (genus).
/// </summary>
public interface IAethaloperca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
