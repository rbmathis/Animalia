namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ceratiidae.Cryptopsaras;

/// <summary>
/// Interface defining characteristics of Cryptopsaras (genus).
/// </summary>
public interface ICryptopsaras
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
