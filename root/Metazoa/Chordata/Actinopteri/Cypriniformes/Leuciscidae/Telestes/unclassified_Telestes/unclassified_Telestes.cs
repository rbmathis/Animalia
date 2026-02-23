using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Telestes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Telestes.unclassified_Telestes;

/// <summary>
/// Abstract class for unclassified Telestes (no rank).
/// NCBI TaxId: 2677709
/// </summary>
public abstract class unclassified_Telestes : Telestes, Iunclassified_Telestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Telestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677709;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Telestes";
}
