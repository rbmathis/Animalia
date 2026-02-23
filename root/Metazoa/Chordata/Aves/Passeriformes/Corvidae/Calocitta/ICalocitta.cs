namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Calocitta;

/// <summary>
/// Interface defining characteristics of Calocitta (genus).
/// </summary>
public interface ICalocitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
