using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Boiruna;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Boiruna.unclassified_Boiruna;

/// <summary>
/// Abstract class for unclassified Boiruna (no rank).
/// NCBI TaxId: 3059252
/// </summary>
public abstract class unclassified_Boiruna : Boiruna, Iunclassified_Boiruna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boiruna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3059252;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boiruna";
}
