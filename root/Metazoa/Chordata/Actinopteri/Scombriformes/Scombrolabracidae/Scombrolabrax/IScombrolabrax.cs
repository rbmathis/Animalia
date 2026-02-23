namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombrolabracidae.Scombrolabrax;

/// <summary>
/// Interface defining characteristics of Scombrolabrax (genus).
/// </summary>
public interface IScombrolabrax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
