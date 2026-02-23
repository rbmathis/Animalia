using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Tympanocryptis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Tympanocryptis.unclassified_Tympanocryptis;

/// <summary>
/// Abstract class for unclassified Tympanocryptis (no rank).
/// NCBI TaxId: 2621238
/// </summary>
public abstract class unclassified_Tympanocryptis : Tympanocryptis, Iunclassified_Tympanocryptis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tympanocryptis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621238;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tympanocryptis";
}
