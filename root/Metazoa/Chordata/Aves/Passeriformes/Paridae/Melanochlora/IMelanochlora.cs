namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Melanochlora;

/// <summary>
/// Interface defining characteristics of Melanochlora (genus).
/// </summary>
public interface IMelanochlora
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
