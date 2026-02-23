using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Uropsilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Uropsilus.unclassified_Uropsilus;

/// <summary>
/// Abstract class for unclassified Uropsilus (no rank).
/// NCBI TaxId: 2640566
/// </summary>
public abstract class unclassified_Uropsilus : Uropsilus, Iunclassified_Uropsilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Uropsilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640566;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Uropsilus";
}
