namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Platalea;

/// <summary>
/// Interface defining characteristics of Platalea (genus).
/// </summary>
public interface IPlatalea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
