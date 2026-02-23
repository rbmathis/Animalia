using AnimalKingdom.root.Metazoa.Chordata.Appendicularia;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.unclassified_Appendicularia_in_tunicates_class;

/// <summary>
/// Abstract class for unclassified Appendicularia (in: tunicates, class) (no rank).
/// NCBI TaxId: 3026148
/// </summary>
public abstract class unclassified_Appendicularia_in_tunicates_class : Appendicularia, Iunclassified_Appendicularia_in_tunicates_class
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Appendicularia (in: tunicates, class)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3026148;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Appendicularia_in_tunicates_class";
}
