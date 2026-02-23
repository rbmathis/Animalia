namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Bucephala;

/// <summary>
/// Interface defining characteristics of Bucephala (genus).
/// </summary>
public interface IBucephala
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
