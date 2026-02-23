namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Platysmurus;

/// <summary>
/// Interface defining characteristics of Platysmurus (genus).
/// </summary>
public interface IPlatysmurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
