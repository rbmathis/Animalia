using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Opsanus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Opsanus.unclassified_Opsanus;

/// <summary>
/// Abstract class for unclassified Opsanus (no rank).
/// NCBI TaxId: 2677741
/// </summary>
public abstract class unclassified_Opsanus : Opsanus, Iunclassified_Opsanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Opsanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677741;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Opsanus";
}
