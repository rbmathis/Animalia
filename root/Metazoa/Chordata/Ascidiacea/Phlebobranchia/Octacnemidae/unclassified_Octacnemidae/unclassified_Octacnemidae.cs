using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.unclassified_Octacnemidae;

/// <summary>
/// Abstract class for unclassified Octacnemidae (no rank).
/// NCBI TaxId: 3475076
/// </summary>
public abstract class unclassified_Octacnemidae : Octacnemidae, Iunclassified_Octacnemidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Octacnemidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3475076;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Octacnemidae";
}
