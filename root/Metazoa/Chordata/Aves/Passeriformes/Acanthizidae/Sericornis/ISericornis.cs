namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Sericornis;

/// <summary>
/// Interface defining characteristics of Sericornis (genus).
/// </summary>
public interface ISericornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
