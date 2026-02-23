namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Eudromia;

/// <summary>
/// Interface defining characteristics of Eudromia (genus).
/// </summary>
public interface IEudromia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
