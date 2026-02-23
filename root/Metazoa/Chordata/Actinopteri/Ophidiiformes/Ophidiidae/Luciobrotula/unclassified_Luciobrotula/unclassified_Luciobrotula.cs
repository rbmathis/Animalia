using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Luciobrotula;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Luciobrotula.unclassified_Luciobrotula;

/// <summary>
/// Abstract class for unclassified Luciobrotula (no rank).
/// NCBI TaxId: 2619362
/// </summary>
public abstract class unclassified_Luciobrotula : Luciobrotula, Iunclassified_Luciobrotula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Luciobrotula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619362;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Luciobrotula";
}
