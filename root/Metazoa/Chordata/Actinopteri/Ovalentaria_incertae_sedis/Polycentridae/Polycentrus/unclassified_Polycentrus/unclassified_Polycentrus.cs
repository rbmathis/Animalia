using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Polycentridae.Polycentrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Polycentridae.Polycentrus.unclassified_Polycentrus;

/// <summary>
/// Abstract class for unclassified Polycentrus (no rank).
/// NCBI TaxId: 3101892
/// </summary>
public abstract class unclassified_Polycentrus : Polycentrus, Iunclassified_Polycentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polycentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101892;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polycentrus";
}
