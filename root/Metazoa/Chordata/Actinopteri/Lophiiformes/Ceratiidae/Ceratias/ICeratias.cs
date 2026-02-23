namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ceratiidae.Ceratias;

/// <summary>
/// Interface defining characteristics of Ceratias (genus).
/// </summary>
public interface ICeratias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
