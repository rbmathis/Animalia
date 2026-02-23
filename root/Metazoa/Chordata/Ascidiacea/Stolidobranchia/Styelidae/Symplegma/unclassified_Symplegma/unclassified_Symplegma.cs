using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Symplegma;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Symplegma.unclassified_Symplegma;

/// <summary>
/// Abstract class for unclassified Symplegma (no rank).
/// NCBI TaxId: 2790814
/// </summary>
public abstract class unclassified_Symplegma : Symplegma, Iunclassified_Symplegma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Symplegma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2790814;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Symplegma";
}
