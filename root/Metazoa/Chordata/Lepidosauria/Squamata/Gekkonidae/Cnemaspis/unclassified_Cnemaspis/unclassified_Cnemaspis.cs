using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cnemaspis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cnemaspis.unclassified_Cnemaspis;

/// <summary>
/// Abstract class for unclassified Cnemaspis (no rank).
/// NCBI TaxId: 2645450
/// </summary>
public abstract class unclassified_Cnemaspis : Cnemaspis, Iunclassified_Cnemaspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cnemaspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645450;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cnemaspis";
}
