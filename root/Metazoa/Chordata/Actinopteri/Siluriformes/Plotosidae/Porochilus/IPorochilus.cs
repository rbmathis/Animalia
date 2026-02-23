namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Porochilus;

/// <summary>
/// Interface defining characteristics of Porochilus (genus).
/// </summary>
public interface IPorochilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
