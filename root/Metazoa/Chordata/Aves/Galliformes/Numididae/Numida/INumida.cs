namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae.Numida;

/// <summary>
/// Interface defining characteristics of Numida (genus).
/// </summary>
public interface INumida
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
