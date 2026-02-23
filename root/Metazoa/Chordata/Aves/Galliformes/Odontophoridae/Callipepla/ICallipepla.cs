namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Callipepla;

/// <summary>
/// Interface defining characteristics of Callipepla (genus).
/// </summary>
public interface ICallipepla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
