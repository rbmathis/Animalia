namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Centropogon;

/// <summary>
/// Interface defining characteristics of Centropogon (genus).
/// </summary>
public interface ICentropogon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
