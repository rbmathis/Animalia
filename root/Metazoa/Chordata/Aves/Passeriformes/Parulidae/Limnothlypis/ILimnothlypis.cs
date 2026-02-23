namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Limnothlypis;

/// <summary>
/// Interface defining characteristics of Limnothlypis (genus).
/// </summary>
public interface ILimnothlypis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
