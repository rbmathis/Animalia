namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Hemirhamphodon;

/// <summary>
/// Interface defining characteristics of Hemirhamphodon (genus).
/// </summary>
public interface IHemirhamphodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
