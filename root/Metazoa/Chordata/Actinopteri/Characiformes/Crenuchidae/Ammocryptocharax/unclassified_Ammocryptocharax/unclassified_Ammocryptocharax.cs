using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Ammocryptocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Ammocryptocharax.unclassified_Ammocryptocharax;

/// <summary>
/// Abstract class for unclassified Ammocryptocharax (no rank).
/// NCBI TaxId: 3101806
/// </summary>
public abstract class unclassified_Ammocryptocharax : Ammocryptocharax, Iunclassified_Ammocryptocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ammocryptocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101806;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ammocryptocharax";
}
