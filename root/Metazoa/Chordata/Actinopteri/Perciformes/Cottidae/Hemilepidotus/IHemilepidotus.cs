namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Hemilepidotus;

/// <summary>
/// Interface defining characteristics of Hemilepidotus (genus).
/// </summary>
public interface IHemilepidotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
