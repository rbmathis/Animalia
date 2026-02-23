namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae.Phractolaemus;

/// <summary>
/// Interface defining characteristics of Phractolaemus (genus).
/// </summary>
public interface IPhractolaemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
