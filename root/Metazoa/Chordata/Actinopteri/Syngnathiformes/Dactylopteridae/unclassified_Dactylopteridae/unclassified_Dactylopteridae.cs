using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Dactylopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Dactylopteridae.unclassified_Dactylopteridae;

/// <summary>
/// Abstract class for unclassified Dactylopteridae (no rank).
/// NCBI TaxId: 2613802
/// </summary>
public abstract class unclassified_Dactylopteridae : Dactylopteridae, Iunclassified_Dactylopteridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dactylopteridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613802;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dactylopteridae";
}
