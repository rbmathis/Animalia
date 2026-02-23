using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Stigmatopora;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Stigmatopora.unclassified_Stigmatopora;

/// <summary>
/// Abstract class for unclassified Stigmatopora (no rank).
/// NCBI TaxId: 2647271
/// </summary>
public abstract class unclassified_Stigmatopora : Stigmatopora, Iunclassified_Stigmatopora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stigmatopora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647271;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stigmatopora";
}
