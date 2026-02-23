namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Cyanoloxia;

/// <summary>
/// Interface defining characteristics of Cyanoloxia (genus).
/// </summary>
public interface ICyanoloxia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
