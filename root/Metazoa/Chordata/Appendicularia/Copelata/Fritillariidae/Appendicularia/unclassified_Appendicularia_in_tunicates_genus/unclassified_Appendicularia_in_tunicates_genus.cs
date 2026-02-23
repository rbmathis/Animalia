using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae.Appendicularia;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae.Appendicularia.unclassified_Appendicularia_in_tunicates_genus;

/// <summary>
/// Abstract class for unclassified Appendicularia (in: tunicates, genus) (no rank).
/// NCBI TaxId: 2688260
/// </summary>
public abstract class unclassified_Appendicularia_in_tunicates_genus : Appendicularia, Iunclassified_Appendicularia_in_tunicates_genus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Appendicularia (in: tunicates, genus)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688260;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Appendicularia_in_tunicates_genus";
}
