using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Copionodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Copionodon.unclassified_Copionodon;

/// <summary>
/// Abstract class for unclassified Copionodon (no rank).
/// NCBI TaxId: 2685812
/// </summary>
public abstract class unclassified_Copionodon : Copionodon, Iunclassified_Copionodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Copionodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685812;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Copionodon";
}
