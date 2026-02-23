namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Hapalogenyidae.Hapalogenys;

/// <summary>
/// Interface defining characteristics of Hapalogenys (genus).
/// </summary>
public interface IHapalogenys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
