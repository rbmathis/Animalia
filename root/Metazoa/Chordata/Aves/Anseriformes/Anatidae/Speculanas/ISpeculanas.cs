namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Speculanas;

/// <summary>
/// Interface defining characteristics of Speculanas (genus).
/// </summary>
public interface ISpeculanas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
