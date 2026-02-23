namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Alpiscaptulus;

/// <summary>
/// Interface defining characteristics of Alpiscaptulus (genus).
/// </summary>
public interface IAlpiscaptulus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
