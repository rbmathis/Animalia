namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Somniosus;

/// <summary>
/// Interface defining characteristics of Somniosus (genus).
/// </summary>
public interface ISomniosus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
