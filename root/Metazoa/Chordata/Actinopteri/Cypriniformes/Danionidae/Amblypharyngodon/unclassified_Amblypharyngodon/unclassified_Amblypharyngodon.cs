using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Amblypharyngodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Amblypharyngodon.unclassified_Amblypharyngodon;

/// <summary>
/// Abstract class for unclassified Amblypharyngodon (no rank).
/// NCBI TaxId: 2642029
/// </summary>
public abstract class unclassified_Amblypharyngodon : Amblypharyngodon, Iunclassified_Amblypharyngodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amblypharyngodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642029;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amblypharyngodon";
}
