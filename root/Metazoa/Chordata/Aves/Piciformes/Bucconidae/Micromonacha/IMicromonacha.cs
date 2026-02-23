namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Micromonacha;

/// <summary>
/// Interface defining characteristics of Micromonacha (genus).
/// </summary>
public interface IMicromonacha
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
