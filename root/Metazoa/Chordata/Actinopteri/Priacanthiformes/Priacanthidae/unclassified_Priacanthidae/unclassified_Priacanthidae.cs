using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae.unclassified_Priacanthidae;

/// <summary>
/// Abstract class for unclassified Priacanthidae (no rank).
/// NCBI TaxId: 1963733
/// </summary>
public abstract class unclassified_Priacanthidae : Priacanthidae, Iunclassified_Priacanthidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Priacanthidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1963733;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Priacanthidae";
}
