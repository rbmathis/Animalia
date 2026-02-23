using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Elephantulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Elephantulus.unclassified_Elephantulus;

/// <summary>
/// Abstract class for unclassified Elephantulus (no rank).
/// NCBI TaxId: 2642962
/// </summary>
public abstract class unclassified_Elephantulus : Elephantulus, Iunclassified_Elephantulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elephantulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642962;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elephantulus";
}
