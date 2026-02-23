namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Himantornis;

/// <summary>
/// Interface defining characteristics of Himantornis (genus).
/// </summary>
public interface IHimantornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
