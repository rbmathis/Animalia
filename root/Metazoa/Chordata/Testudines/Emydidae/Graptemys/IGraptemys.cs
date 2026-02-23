namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

/// <summary>
/// Interface defining characteristics of Graptemys (genus).
/// </summary>
public interface IGraptemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
