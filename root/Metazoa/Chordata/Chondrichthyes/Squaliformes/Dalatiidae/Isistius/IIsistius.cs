namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Dalatiidae.Isistius;

/// <summary>
/// Interface defining characteristics of Isistius (genus).
/// </summary>
public interface IIsistius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
