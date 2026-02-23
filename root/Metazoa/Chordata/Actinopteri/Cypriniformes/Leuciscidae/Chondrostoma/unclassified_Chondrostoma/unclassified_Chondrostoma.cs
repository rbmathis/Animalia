using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Chondrostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Chondrostoma.unclassified_Chondrostoma;

/// <summary>
/// Abstract class for unclassified Chondrostoma (no rank).
/// NCBI TaxId: 2685179
/// </summary>
public abstract class unclassified_Chondrostoma : Chondrostoma, Iunclassified_Chondrostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chondrostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685179;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chondrostoma";
}
