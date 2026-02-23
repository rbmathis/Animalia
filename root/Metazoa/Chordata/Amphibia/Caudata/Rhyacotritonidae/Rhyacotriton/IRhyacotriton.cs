namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Rhyacotritonidae.Rhyacotriton;

/// <summary>
/// Interface defining characteristics of Rhyacotriton (genus).
/// </summary>
public interface IRhyacotriton
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
