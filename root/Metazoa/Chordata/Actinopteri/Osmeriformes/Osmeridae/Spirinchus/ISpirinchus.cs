namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae.Spirinchus;

/// <summary>
/// Interface defining characteristics of Spirinchus (genus).
/// </summary>
public interface ISpirinchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
