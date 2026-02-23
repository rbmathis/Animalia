namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Allocebus;

/// <summary>
/// Interface defining characteristics of Allocebus (genus).
/// </summary>
public interface IAllocebus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
