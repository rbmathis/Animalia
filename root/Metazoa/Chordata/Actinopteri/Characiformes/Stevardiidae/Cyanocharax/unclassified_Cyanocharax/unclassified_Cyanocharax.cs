using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Cyanocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Cyanocharax.unclassified_Cyanocharax;

/// <summary>
/// Abstract class for unclassified Cyanocharax (no rank).
/// NCBI TaxId: 2643217
/// </summary>
public abstract class unclassified_Cyanocharax : Cyanocharax, Iunclassified_Cyanocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyanocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643217;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyanocharax";
}
