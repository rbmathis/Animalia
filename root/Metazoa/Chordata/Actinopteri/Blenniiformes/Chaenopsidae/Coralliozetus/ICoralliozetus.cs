namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Coralliozetus;

/// <summary>
/// Interface defining characteristics of Coralliozetus (genus).
/// </summary>
public interface ICoralliozetus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
