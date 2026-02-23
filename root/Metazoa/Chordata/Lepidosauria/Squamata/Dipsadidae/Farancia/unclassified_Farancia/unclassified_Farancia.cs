using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Farancia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Farancia.unclassified_Farancia;

/// <summary>
/// Abstract class for unclassified Farancia (no rank).
/// NCBI TaxId: 2633530
/// </summary>
public abstract class unclassified_Farancia : Farancia, Iunclassified_Farancia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Farancia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633530;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Farancia";
}
