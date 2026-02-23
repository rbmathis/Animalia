namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kuhliidae.Kuhlia;

/// <summary>
/// Interface defining characteristics of Kuhlia (genus).
/// </summary>
public interface IKuhlia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
