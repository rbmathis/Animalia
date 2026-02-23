using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amblyglyphidodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amblyglyphidodon.unclassified_Amblyglyphidodon;

/// <summary>
/// Abstract class for unclassified Amblyglyphidodon (no rank).
/// NCBI TaxId: 2641605
/// </summary>
public abstract class unclassified_Amblyglyphidodon : Amblyglyphidodon, Iunclassified_Amblyglyphidodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amblyglyphidodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641605;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amblyglyphidodon";
}
