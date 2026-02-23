namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Malacoctenus;

/// <summary>
/// Interface defining characteristics of Malacoctenus (genus).
/// </summary>
public interface IMalacoctenus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
