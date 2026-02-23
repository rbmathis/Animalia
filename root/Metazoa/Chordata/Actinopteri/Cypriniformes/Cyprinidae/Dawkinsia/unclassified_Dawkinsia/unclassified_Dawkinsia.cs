using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Dawkinsia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Dawkinsia.unclassified_Dawkinsia;

/// <summary>
/// Abstract class for unclassified Dawkinsia (no rank).
/// NCBI TaxId: 2726104
/// </summary>
public abstract class unclassified_Dawkinsia : Dawkinsia, Iunclassified_Dawkinsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dawkinsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726104;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dawkinsia";
}
