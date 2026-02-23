using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Ctenopharyngodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Ctenopharyngodon.unclassified_Ctenopharyngodon;

/// <summary>
/// Abstract class for unclassified Ctenopharyngodon (no rank).
/// NCBI TaxId: 2682963
/// </summary>
public abstract class unclassified_Ctenopharyngodon : Ctenopharyngodon, Iunclassified_Ctenopharyngodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ctenopharyngodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2682963;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ctenopharyngodon";
}
