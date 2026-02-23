namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae.Electron;

/// <summary>
/// Interface defining characteristics of Electron (genus).
/// </summary>
public interface IElectron
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
