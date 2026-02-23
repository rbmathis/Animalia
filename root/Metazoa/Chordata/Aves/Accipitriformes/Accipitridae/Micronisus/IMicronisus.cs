namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Micronisus;

/// <summary>
/// Interface defining characteristics of Micronisus (genus).
/// </summary>
public interface IMicronisus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
