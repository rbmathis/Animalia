namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Dendrocygna;

/// <summary>
/// Interface defining characteristics of Dendrocygna (genus).
/// </summary>
public interface IDendrocygna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
