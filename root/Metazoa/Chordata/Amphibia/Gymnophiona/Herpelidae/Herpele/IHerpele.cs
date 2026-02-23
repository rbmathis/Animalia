namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Herpelidae.Herpele;

/// <summary>
/// Interface defining characteristics of Herpele (genus).
/// </summary>
public interface IHerpele
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
