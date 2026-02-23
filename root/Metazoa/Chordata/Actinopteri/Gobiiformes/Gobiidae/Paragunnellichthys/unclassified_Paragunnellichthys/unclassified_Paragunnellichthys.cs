using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Paragunnellichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Paragunnellichthys.unclassified_Paragunnellichthys;

/// <summary>
/// Abstract class for unclassified Paragunnellichthys (no rank).
/// NCBI TaxId: 2696271
/// </summary>
public abstract class unclassified_Paragunnellichthys : Paragunnellichthys, Iunclassified_Paragunnellichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paragunnellichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696271;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paragunnellichthys";
}
