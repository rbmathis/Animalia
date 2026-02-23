using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.unclassified_Phlebobranchia;

/// <summary>
/// Abstract class for unclassified Phlebobranchia (no rank).
/// NCBI TaxId: 2672151
/// </summary>
public abstract class unclassified_Phlebobranchia : Phlebobranchia, Iunclassified_Phlebobranchia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phlebobranchia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2672151;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phlebobranchia";
}
