namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Polyodontidae.Polyodon;

/// <summary>
/// Interface defining characteristics of Polyodon (genus).
/// </summary>
public interface IPolyodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
