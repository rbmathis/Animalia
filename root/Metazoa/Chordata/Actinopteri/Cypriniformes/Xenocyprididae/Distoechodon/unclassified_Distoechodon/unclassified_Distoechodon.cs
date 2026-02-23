using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Distoechodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Distoechodon.unclassified_Distoechodon;

/// <summary>
/// Abstract class for unclassified Distoechodon (no rank).
/// NCBI TaxId: 2677168
/// </summary>
public abstract class unclassified_Distoechodon : Distoechodon, Iunclassified_Distoechodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Distoechodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677168;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Distoechodon";
}
