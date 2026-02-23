using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cleithracara;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cleithracara.unclassified_Cleithracara;

/// <summary>
/// Abstract class for unclassified Cleithracara (no rank).
/// NCBI TaxId: 3101830
/// </summary>
public abstract class unclassified_Cleithracara : Cleithracara, Iunclassified_Cleithracara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cleithracara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101830;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cleithracara";
}
