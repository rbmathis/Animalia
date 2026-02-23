namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Cistugidae.Cistugo;

/// <summary>
/// Interface defining characteristics of Cistugo (genus).
/// </summary>
public interface ICistugo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
