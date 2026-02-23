namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Chloebia;

/// <summary>
/// Interface defining characteristics of Chloebia (genus).
/// </summary>
public interface IChloebia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
