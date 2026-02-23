namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae.Typhlonectes;

/// <summary>
/// Interface defining characteristics of Typhlonectes (genus).
/// </summary>
public interface ITyphlonectes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
