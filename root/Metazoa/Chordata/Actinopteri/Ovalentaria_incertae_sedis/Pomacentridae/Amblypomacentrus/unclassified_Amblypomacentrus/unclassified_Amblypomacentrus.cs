using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amblypomacentrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amblypomacentrus.unclassified_Amblypomacentrus;

/// <summary>
/// Abstract class for unclassified Amblypomacentrus (no rank).
/// NCBI TaxId: 2639819
/// </summary>
public abstract class unclassified_Amblypomacentrus : Amblypomacentrus, Iunclassified_Amblypomacentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amblypomacentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639819;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amblypomacentrus";
}
