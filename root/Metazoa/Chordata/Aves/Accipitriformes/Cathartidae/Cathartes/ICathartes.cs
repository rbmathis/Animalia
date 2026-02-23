namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Cathartidae.Cathartes;

/// <summary>
/// Interface defining characteristics of Cathartes (genus).
/// </summary>
public interface ICathartes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
