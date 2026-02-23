using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae.Fritillaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae.Fritillaria.unclassified_Fritillaria_in_tunicates;

/// <summary>
/// Abstract class for unclassified Fritillaria (in: tunicates) (no rank).
/// NCBI TaxId: 2688485
/// </summary>
public abstract class unclassified_Fritillaria_in_tunicates : Fritillaria, Iunclassified_Fritillaria_in_tunicates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fritillaria (in: tunicates)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688485;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fritillaria_in_tunicates";
}
