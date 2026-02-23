namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Thambetochen;

/// <summary>
/// Interface defining characteristics of Thambetochen (genus).
/// </summary>
public interface IThambetochen
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
