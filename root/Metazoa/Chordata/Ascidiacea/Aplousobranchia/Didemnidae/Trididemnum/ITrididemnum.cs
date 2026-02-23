namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Trididemnum;

/// <summary>
/// Interface defining characteristics of Trididemnum (genus).
/// </summary>
public interface ITrididemnum
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
