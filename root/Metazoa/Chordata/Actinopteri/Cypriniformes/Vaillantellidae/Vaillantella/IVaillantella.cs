namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Vaillantellidae.Vaillantella;

/// <summary>
/// Interface defining characteristics of Vaillantella (genus).
/// </summary>
public interface IVaillantella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
