namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Pristiophoridae.Pliotrema;

/// <summary>
/// Interface defining characteristics of Pliotrema (genus).
/// </summary>
public interface IPliotrema
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
