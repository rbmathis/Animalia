namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Iconisemion;

/// <summary>
/// Interface defining characteristics of Iconisemion (genus).
/// </summary>
public interface IIconisemion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
