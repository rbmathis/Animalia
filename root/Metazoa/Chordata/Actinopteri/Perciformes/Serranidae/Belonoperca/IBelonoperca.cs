namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Belonoperca;

/// <summary>
/// Interface defining characteristics of Belonoperca (genus).
/// </summary>
public interface IBelonoperca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
