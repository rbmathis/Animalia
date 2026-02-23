namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Coscoroba;

/// <summary>
/// Interface defining characteristics of Coscoroba (genus).
/// </summary>
public interface ICoscoroba
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
