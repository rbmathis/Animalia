namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Leontocebus;

/// <summary>
/// Interface defining characteristics of Leontocebus (genus).
/// </summary>
public interface ILeontocebus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
