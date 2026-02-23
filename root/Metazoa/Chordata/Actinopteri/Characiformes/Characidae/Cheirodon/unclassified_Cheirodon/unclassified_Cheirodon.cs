using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cheirodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cheirodon.unclassified_Cheirodon;

/// <summary>
/// Abstract class for unclassified Cheirodon (no rank).
/// NCBI TaxId: 2631797
/// </summary>
public abstract class unclassified_Cheirodon : Cheirodon, Iunclassified_Cheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631797;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cheirodon";
}
