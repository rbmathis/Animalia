namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Parazenidae.Stethopristes;

/// <summary>
/// Interface defining characteristics of Stethopristes (genus).
/// </summary>
public interface IStethopristes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
