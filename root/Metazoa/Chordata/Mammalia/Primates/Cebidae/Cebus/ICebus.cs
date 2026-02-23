namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Cebus;

/// <summary>
/// Interface defining characteristics of Cebus (genus).
/// </summary>
public interface ICebus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
