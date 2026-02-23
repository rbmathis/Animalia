using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Pomacentrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Pomacentrus.unclassified_Pomacentrus;

/// <summary>
/// Abstract class for unclassified Pomacentrus (no rank).
/// NCBI TaxId: 2633721
/// </summary>
public abstract class unclassified_Pomacentrus : Pomacentrus, Iunclassified_Pomacentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pomacentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633721;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pomacentrus";
}
