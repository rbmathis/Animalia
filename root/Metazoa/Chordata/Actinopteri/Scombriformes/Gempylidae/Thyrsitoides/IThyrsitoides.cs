namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Thyrsitoides;

/// <summary>
/// Interface defining characteristics of Thyrsitoides (genus).
/// </summary>
public interface IThyrsitoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
