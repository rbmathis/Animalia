namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Enoplosidae.Enoplosus;

/// <summary>
/// Interface defining characteristics of Enoplosus (genus).
/// </summary>
public interface IEnoplosus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
