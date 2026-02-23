using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Perophoridae.Ecteinascidia;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Perophoridae.Ecteinascidia.unclassified_Ecteinascidia;

/// <summary>
/// Abstract class for unclassified Ecteinascidia (no rank).
/// NCBI TaxId: 2790737
/// </summary>
public abstract class unclassified_Ecteinascidia : Ecteinascidia, Iunclassified_Ecteinascidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ecteinascidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2790737;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ecteinascidia";
}
