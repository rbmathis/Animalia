using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Culter;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Culter.unclassified_Culter;

/// <summary>
/// Abstract class for unclassified Culter (no rank).
/// NCBI TaxId: 2627209
/// </summary>
public abstract class unclassified_Culter : Culter, Iunclassified_Culter
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Culter";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627209;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Culter";
}
