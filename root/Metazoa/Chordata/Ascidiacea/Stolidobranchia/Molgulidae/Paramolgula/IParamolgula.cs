namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae.Paramolgula;

/// <summary>
/// Interface defining characteristics of Paramolgula (genus).
/// </summary>
public interface IParamolgula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
