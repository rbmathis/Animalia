namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Xenocyprioides;

/// <summary>
/// Interface defining characteristics of Xenocyprioides (genus).
/// </summary>
public interface IXenocyprioides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
