using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae.Evermannella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae.Evermannella.unclassified_Evermannella;

/// <summary>
/// Abstract class for unclassified Evermannella (no rank).
/// NCBI TaxId: 2632400
/// </summary>
public abstract class unclassified_Evermannella : Evermannella, Iunclassified_Evermannella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Evermannella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632400;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Evermannella";
}
