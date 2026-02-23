using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.Octacnemus;

/// <summary>
/// Abstract class for Octacnemus (genus).
/// NCBI TaxId: 3092876
/// </summary>
public abstract class Octacnemus : Octacnemidae, IOctacnemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Octacnemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3092876;

    /// <inheritdoc />
    public virtual string GenusName => "Octacnemus";

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
