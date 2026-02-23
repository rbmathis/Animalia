namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cnemophilus;

/// <summary>
/// Interface defining characteristics of Cnemophilus (genus).
/// </summary>
public interface ICnemophilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
