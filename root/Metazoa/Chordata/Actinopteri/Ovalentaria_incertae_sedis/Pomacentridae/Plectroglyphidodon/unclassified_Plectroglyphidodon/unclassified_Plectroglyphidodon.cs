using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Plectroglyphidodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Plectroglyphidodon.unclassified_Plectroglyphidodon;

/// <summary>
/// Abstract class for unclassified Plectroglyphidodon (no rank).
/// NCBI TaxId: 2989967
/// </summary>
public abstract class unclassified_Plectroglyphidodon : Plectroglyphidodon, Iunclassified_Plectroglyphidodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plectroglyphidodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2989967;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plectroglyphidodon";
}
