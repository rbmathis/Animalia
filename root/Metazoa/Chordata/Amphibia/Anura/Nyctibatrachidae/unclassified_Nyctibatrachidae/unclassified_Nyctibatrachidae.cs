using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae.unclassified_Nyctibatrachidae;

/// <summary>
/// Abstract class for unclassified Nyctibatrachidae (no rank).
/// NCBI TaxId: 2487692
/// </summary>
public abstract class unclassified_Nyctibatrachidae : Nyctibatrachidae, Iunclassified_Nyctibatrachidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nyctibatrachidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2487692;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nyctibatrachidae";
}
