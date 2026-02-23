namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phytotriades;

/// <summary>
/// Interface defining characteristics of Phytotriades (genus).
/// </summary>
public interface IPhytotriades
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
