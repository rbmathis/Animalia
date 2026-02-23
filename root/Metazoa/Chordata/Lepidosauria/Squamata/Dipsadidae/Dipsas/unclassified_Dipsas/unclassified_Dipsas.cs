using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Dipsas;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Dipsas.unclassified_Dipsas;

/// <summary>
/// Abstract class for unclassified Dipsas (no rank).
/// NCBI TaxId: 2640788
/// </summary>
public abstract class unclassified_Dipsas : Dipsas, Iunclassified_Dipsas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dipsas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640788;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dipsas";
}
