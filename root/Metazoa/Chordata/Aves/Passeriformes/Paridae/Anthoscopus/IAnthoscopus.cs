namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Anthoscopus;

/// <summary>
/// Interface defining characteristics of Anthoscopus (genus).
/// </summary>
public interface IAnthoscopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
