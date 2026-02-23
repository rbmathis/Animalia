using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Toxabramis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Toxabramis.unclassified_Toxabramis;

/// <summary>
/// Abstract class for unclassified Toxabramis (no rank).
/// NCBI TaxId: 2639640
/// </summary>
public abstract class unclassified_Toxabramis : Toxabramis, Iunclassified_Toxabramis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Toxabramis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639640;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Toxabramis";
}
