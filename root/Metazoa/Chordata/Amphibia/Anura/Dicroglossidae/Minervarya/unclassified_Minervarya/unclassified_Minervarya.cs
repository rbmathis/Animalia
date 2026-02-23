using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Minervarya;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Minervarya.unclassified_Minervarya;

/// <summary>
/// Abstract class for unclassified Minervarya (no rank).
/// NCBI TaxId: 2801370
/// </summary>
public abstract class unclassified_Minervarya : Minervarya, Iunclassified_Minervarya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Minervarya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2801370;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Minervarya";
}
