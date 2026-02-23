namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae.Lipogenys;

/// <summary>
/// Interface defining characteristics of Lipogenys (genus).
/// </summary>
public interface ILipogenys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
