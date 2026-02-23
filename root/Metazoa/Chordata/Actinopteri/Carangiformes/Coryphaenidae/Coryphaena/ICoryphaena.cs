namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Coryphaenidae.Coryphaena;

/// <summary>
/// Interface defining characteristics of Coryphaena (genus).
/// </summary>
public interface ICoryphaena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
