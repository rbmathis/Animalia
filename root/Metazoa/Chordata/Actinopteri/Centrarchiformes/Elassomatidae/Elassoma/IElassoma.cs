namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Elassomatidae.Elassoma;

/// <summary>
/// Interface defining characteristics of Elassoma (genus).
/// </summary>
public interface IElassoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
