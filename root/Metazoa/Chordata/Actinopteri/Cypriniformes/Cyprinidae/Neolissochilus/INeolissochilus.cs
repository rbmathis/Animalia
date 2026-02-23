namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Neolissochilus;

/// <summary>
/// Interface defining characteristics of Neolissochilus (genus).
/// </summary>
public interface INeolissochilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
