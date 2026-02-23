namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Mergus;

/// <summary>
/// Interface defining characteristics of Mergus (genus).
/// </summary>
public interface IMergus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
