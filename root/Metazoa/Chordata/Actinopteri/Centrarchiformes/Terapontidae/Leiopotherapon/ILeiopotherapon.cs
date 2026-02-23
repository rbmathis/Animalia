namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Leiopotherapon;

/// <summary>
/// Interface defining characteristics of Leiopotherapon (genus).
/// </summary>
public interface ILeiopotherapon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
