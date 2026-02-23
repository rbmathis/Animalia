namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Stephanoberycidae.Malacosarcus;

/// <summary>
/// Interface defining characteristics of Malacosarcus (genus).
/// </summary>
public interface IMalacosarcus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
