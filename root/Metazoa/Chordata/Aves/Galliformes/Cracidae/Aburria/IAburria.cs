namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Aburria;

/// <summary>
/// Interface defining characteristics of Aburria (genus).
/// </summary>
public interface IAburria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
