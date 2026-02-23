using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Neopomacentrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Neopomacentrus.unclassified_Neopomacentrus;

/// <summary>
/// Abstract class for unclassified Neopomacentrus (no rank).
/// NCBI TaxId: 2635369
/// </summary>
public abstract class unclassified_Neopomacentrus : Neopomacentrus, Iunclassified_Neopomacentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neopomacentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635369;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neopomacentrus";
}
