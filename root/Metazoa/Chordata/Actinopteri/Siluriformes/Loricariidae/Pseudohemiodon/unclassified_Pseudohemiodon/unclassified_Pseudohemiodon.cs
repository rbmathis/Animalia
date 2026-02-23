using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudohemiodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudohemiodon.unclassified_Pseudohemiodon;

/// <summary>
/// Abstract class for unclassified Pseudohemiodon (no rank).
/// NCBI TaxId: 2628458
/// </summary>
public abstract class unclassified_Pseudohemiodon : Pseudohemiodon, Iunclassified_Pseudohemiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudohemiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628458;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudohemiodon";
}
