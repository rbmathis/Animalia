namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Dermophiidae.Gymnopis;

/// <summary>
/// Interface defining characteristics of Gymnopis (genus).
/// </summary>
public interface IGymnopis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
