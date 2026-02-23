using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Leuciscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Leuciscus.unclassified_Leuciscus;

/// <summary>
/// Abstract class for unclassified Leuciscus (no rank).
/// NCBI TaxId: 2630443
/// </summary>
public abstract class unclassified_Leuciscus : Leuciscus, Iunclassified_Leuciscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leuciscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630443;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leuciscus";
}
