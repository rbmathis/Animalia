namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Eupodotis;

/// <summary>
/// Interface defining characteristics of Eupodotis (genus).
/// </summary>
public interface IEupodotis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
