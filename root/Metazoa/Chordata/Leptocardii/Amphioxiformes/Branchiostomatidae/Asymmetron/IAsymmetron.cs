namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Asymmetron;

/// <summary>
/// Interface defining characteristics of Asymmetron (genus).
/// </summary>
public interface IAsymmetron
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
