using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.unclassified_Ophichthidae;

/// <summary>
/// Abstract class for unclassified Ophichthidae (no rank).
/// NCBI TaxId: 721882
/// </summary>
public abstract class unclassified_Ophichthidae : Ophichthidae, Iunclassified_Ophichthidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophichthidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 721882;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophichthidae";
}
