namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Herpelidae.Boulengerula;

/// <summary>
/// Interface defining characteristics of Boulengerula (genus).
/// </summary>
public interface IBoulengerula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
