namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Hymenolaimus;

/// <summary>
/// Interface defining characteristics of Hymenolaimus (genus).
/// </summary>
public interface IHymenolaimus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
