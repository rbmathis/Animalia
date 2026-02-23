namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Polymixiiformes.Polymixiidae.Polymixia;

/// <summary>
/// Interface defining characteristics of Polymixia (genus).
/// </summary>
public interface IPolymixia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
