namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Geronticus;

/// <summary>
/// Interface defining characteristics of Geronticus (genus).
/// </summary>
public interface IGeronticus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
