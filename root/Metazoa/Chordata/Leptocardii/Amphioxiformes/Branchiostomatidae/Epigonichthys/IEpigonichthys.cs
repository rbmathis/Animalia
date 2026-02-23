namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Epigonichthys;

/// <summary>
/// Interface defining characteristics of Epigonichthys (genus).
/// </summary>
public interface IEpigonichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
