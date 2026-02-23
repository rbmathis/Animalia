namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Leptostomias;

/// <summary>
/// Interface defining characteristics of Leptostomias (genus).
/// </summary>
public interface ILeptostomias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
