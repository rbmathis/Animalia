using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Prodontocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Prodontocharax.unclassified_Prodontocharax;

/// <summary>
/// Abstract class for unclassified Prodontocharax (no rank).
/// NCBI TaxId: 2638019
/// </summary>
public abstract class unclassified_Prodontocharax : Prodontocharax, Iunclassified_Prodontocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Prodontocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638019;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Prodontocharax";
}
