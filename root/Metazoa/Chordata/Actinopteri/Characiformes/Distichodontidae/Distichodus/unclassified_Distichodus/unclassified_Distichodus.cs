using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Distichodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Distichodus.unclassified_Distichodus;

/// <summary>
/// Abstract class for unclassified Distichodus (no rank).
/// NCBI TaxId: 2638142
/// </summary>
public abstract class unclassified_Distichodus : Distichodus, Iunclassified_Distichodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Distichodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638142;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Distichodus";
}
