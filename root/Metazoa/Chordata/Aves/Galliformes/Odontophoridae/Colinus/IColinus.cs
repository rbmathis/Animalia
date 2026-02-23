namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Colinus;

/// <summary>
/// Interface defining characteristics of Colinus (genus).
/// </summary>
public interface IColinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
