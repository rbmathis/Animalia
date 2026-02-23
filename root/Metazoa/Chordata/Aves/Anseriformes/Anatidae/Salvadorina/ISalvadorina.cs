namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Salvadorina;

/// <summary>
/// Interface defining characteristics of Salvadorina (genus).
/// </summary>
public interface ISalvadorina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
