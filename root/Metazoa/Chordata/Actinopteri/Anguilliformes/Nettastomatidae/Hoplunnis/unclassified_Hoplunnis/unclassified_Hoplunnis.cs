using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Hoplunnis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Hoplunnis.unclassified_Hoplunnis;

/// <summary>
/// Abstract class for unclassified Hoplunnis (no rank).
/// NCBI TaxId: 2890337
/// </summary>
public abstract class unclassified_Hoplunnis : Hoplunnis, Iunclassified_Hoplunnis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hoplunnis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2890337;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hoplunnis";
}
