namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Marmaronetta;

/// <summary>
/// Interface defining characteristics of Marmaronetta (genus).
/// </summary>
public interface IMarmaronetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
