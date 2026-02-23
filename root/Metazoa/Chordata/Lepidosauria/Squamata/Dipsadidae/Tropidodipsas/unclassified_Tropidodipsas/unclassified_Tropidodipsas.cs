using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tropidodipsas;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tropidodipsas.unclassified_Tropidodipsas;

/// <summary>
/// Abstract class for unclassified Tropidodipsas (no rank).
/// NCBI TaxId: 2618447
/// </summary>
public abstract class unclassified_Tropidodipsas : Tropidodipsas, Iunclassified_Tropidodipsas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tropidodipsas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618447;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tropidodipsas";
}
