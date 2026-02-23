namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Myzopodidae.Myzopoda;

/// <summary>
/// Interface defining characteristics of Myzopoda (genus).
/// </summary>
public interface IMyzopoda
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
