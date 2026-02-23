namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Coracornis;

/// <summary>
/// Interface defining characteristics of Coracornis (genus).
/// </summary>
public interface ICoracornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
