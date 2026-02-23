namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Cnemoscopus;

/// <summary>
/// Interface defining characteristics of Cnemoscopus (genus).
/// </summary>
public interface ICnemoscopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
