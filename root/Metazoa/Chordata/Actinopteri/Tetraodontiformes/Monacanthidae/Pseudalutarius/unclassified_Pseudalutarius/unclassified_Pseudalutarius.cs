using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Pseudalutarius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Pseudalutarius.unclassified_Pseudalutarius;

/// <summary>
/// Abstract class for unclassified Pseudalutarius (no rank).
/// NCBI TaxId: 2990003
/// </summary>
public abstract class unclassified_Pseudalutarius : Pseudalutarius, Iunclassified_Pseudalutarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudalutarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990003;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudalutarius";
}
