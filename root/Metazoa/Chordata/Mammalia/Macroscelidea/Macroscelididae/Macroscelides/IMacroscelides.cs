namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Macroscelides;

/// <summary>
/// Interface defining characteristics of Macroscelides (genus).
/// </summary>
public interface IMacroscelides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
