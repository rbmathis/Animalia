namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Typhlias;

/// <summary>
/// Interface defining characteristics of Typhlias (genus).
/// </summary>
public interface ITyphlias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
