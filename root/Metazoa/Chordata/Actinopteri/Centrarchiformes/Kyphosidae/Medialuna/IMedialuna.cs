namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Medialuna;

/// <summary>
/// Interface defining characteristics of Medialuna (genus).
/// </summary>
public interface IMedialuna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
