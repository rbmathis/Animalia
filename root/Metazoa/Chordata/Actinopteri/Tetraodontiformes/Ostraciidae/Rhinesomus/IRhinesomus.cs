namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Rhinesomus;

/// <summary>
/// Interface defining characteristics of Rhinesomus (genus).
/// </summary>
public interface IRhinesomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
