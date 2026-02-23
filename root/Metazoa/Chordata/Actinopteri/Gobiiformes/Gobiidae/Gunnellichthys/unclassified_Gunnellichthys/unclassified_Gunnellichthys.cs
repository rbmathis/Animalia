using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gunnellichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gunnellichthys.unclassified_Gunnellichthys;

/// <summary>
/// Abstract class for unclassified Gunnellichthys (no rank).
/// NCBI TaxId: 2649765
/// </summary>
public abstract class unclassified_Gunnellichthys : Gunnellichthys, Iunclassified_Gunnellichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gunnellichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649765;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gunnellichthys";
}
