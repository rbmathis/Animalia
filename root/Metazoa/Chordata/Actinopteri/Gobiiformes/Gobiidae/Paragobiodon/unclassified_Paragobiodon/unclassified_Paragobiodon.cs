using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Paragobiodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Paragobiodon.unclassified_Paragobiodon;

/// <summary>
/// Abstract class for unclassified Paragobiodon (no rank).
/// NCBI TaxId: 2622674
/// </summary>
public abstract class unclassified_Paragobiodon : Paragobiodon, Iunclassified_Paragobiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paragobiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622674;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paragobiodon";
}
