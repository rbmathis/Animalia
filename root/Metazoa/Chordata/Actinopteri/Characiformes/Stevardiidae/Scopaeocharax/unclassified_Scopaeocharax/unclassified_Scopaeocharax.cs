using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Scopaeocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Scopaeocharax.unclassified_Scopaeocharax;

/// <summary>
/// Abstract class for unclassified Scopaeocharax (no rank).
/// NCBI TaxId: 2622241
/// </summary>
public abstract class unclassified_Scopaeocharax : Scopaeocharax, Iunclassified_Scopaeocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scopaeocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622241;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scopaeocharax";
}
