namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Machlolophus;

/// <summary>
/// Interface defining characteristics of Machlolophus (genus).
/// </summary>
public interface IMachlolophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
