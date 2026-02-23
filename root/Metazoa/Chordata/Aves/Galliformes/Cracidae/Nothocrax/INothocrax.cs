namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Nothocrax;

/// <summary>
/// Interface defining characteristics of Nothocrax (genus).
/// </summary>
public interface INothocrax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
