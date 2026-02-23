namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Sacalia;

/// <summary>
/// Interface defining characteristics of Sacalia (genus).
/// </summary>
public interface ISacalia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
