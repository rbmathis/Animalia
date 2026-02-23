namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Clangula;

/// <summary>
/// Interface defining characteristics of Clangula (genus).
/// </summary>
public interface IClangula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
