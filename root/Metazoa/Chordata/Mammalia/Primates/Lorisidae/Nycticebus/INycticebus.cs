namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.Nycticebus;

/// <summary>
/// Interface defining characteristics of Nycticebus (genus).
/// </summary>
public interface INycticebus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
