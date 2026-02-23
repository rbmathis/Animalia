namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Caproiformes.Caproidae.Antigonia;

/// <summary>
/// Interface defining characteristics of Antigonia (genus).
/// </summary>
public interface IAntigonia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
