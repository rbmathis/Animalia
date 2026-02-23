namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Cynisca;

/// <summary>
/// Interface defining characteristics of Cynisca (genus).
/// </summary>
public interface ICynisca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
