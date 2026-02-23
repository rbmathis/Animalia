namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Deirochelys;

/// <summary>
/// Interface defining characteristics of Deirochelys (genus).
/// </summary>
public interface IDeirochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
