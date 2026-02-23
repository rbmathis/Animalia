namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Engyprosopon;

/// <summary>
/// Interface defining characteristics of Engyprosopon (genus).
/// </summary>
public interface IEngyprosopon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
