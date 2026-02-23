namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.Copeina;

/// <summary>
/// Interface defining characteristics of Copeina (genus).
/// </summary>
public interface ICopeina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
