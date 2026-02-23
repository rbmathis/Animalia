namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.Kaikoja;

/// <summary>
/// Interface defining characteristics of Kaikoja (genus).
/// </summary>
public interface IKaikoja
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
