namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Neoceratiidae.Neoceratias;

/// <summary>
/// Interface defining characteristics of Neoceratias (genus).
/// </summary>
public interface INeoceratias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
