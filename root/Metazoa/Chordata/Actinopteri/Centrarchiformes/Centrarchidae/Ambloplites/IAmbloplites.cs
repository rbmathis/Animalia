namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Ambloplites;

/// <summary>
/// Interface defining characteristics of Ambloplites (genus).
/// </summary>
public interface IAmbloplites
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
