namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Uraeotyphlus;

/// <summary>
/// Interface defining characteristics of Uraeotyphlus (genus).
/// </summary>
public interface IUraeotyphlus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
