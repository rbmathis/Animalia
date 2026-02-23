namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Hydroprogne;

/// <summary>
/// Interface defining characteristics of Hydroprogne (genus).
/// </summary>
public interface IHydroprogne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
