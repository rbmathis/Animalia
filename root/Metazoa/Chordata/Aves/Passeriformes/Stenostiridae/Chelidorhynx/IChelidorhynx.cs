namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Stenostiridae.Chelidorhynx;

/// <summary>
/// Interface defining characteristics of Chelidorhynx (genus).
/// </summary>
public interface IChelidorhynx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
