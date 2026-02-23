using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.unclassified_Pomacentridae;

/// <summary>
/// Abstract class for unclassified Pomacentridae (no rank).
/// NCBI TaxId: 1182097
/// </summary>
public abstract class unclassified_Pomacentridae : Pomacentridae, Iunclassified_Pomacentridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pomacentridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182097;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pomacentridae";
}
