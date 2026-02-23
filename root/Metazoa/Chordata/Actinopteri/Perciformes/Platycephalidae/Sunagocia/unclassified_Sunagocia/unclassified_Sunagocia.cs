using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Sunagocia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Sunagocia.unclassified_Sunagocia;

/// <summary>
/// Abstract class for unclassified Sunagocia (no rank).
/// NCBI TaxId: 3446862
/// </summary>
public abstract class unclassified_Sunagocia : Sunagocia, Iunclassified_Sunagocia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sunagocia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446862;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sunagocia";
}
