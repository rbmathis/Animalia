namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Ostracion;

/// <summary>
/// Interface defining characteristics of Ostracion (genus).
/// </summary>
public interface IOstracion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
