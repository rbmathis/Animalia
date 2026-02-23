namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Monacoa;

/// <summary>
/// Interface defining characteristics of Monacoa (genus).
/// </summary>
public interface IMonacoa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
