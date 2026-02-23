using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Orthonychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Orthonychidae.Orthonyx;

/// <summary>
/// Abstract class for Orthonyx (genus).
/// NCBI TaxId: 38396
/// </summary>
public abstract class Orthonyx : Orthonychidae, IOrthonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38396;

    /// <inheritdoc />
    public virtual string GenusName => "Orthonyx";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
