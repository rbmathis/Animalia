namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Diceratiidae.Bufoceratias;

/// <summary>
/// Interface defining characteristics of Bufoceratias (genus).
/// </summary>
public interface IBufoceratias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
