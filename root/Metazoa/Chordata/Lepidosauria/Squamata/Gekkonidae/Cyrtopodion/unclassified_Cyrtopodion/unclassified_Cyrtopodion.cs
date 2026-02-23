using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cyrtopodion;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cyrtopodion.unclassified_Cyrtopodion;

/// <summary>
/// Abstract class for unclassified Cyrtopodion (no rank).
/// NCBI TaxId: 2637860
/// </summary>
public abstract class unclassified_Cyrtopodion : Cyrtopodion, Iunclassified_Cyrtopodion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyrtopodion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637860;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyrtopodion";
}
