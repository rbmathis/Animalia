namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Cnemotriccus;

/// <summary>
/// Interface defining characteristics of Cnemotriccus (genus).
/// </summary>
public interface ICnemotriccus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
