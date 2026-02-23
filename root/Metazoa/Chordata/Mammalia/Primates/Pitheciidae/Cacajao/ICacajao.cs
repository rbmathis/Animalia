namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Cacajao;

/// <summary>
/// Interface defining characteristics of Cacajao (genus).
/// </summary>
public interface ICacajao
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
