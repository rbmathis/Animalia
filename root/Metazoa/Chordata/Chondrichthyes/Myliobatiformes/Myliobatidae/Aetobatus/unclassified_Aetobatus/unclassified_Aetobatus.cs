using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Aetobatus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Aetobatus.unclassified_Aetobatus;

/// <summary>
/// Abstract class for unclassified Aetobatus (no rank).
/// NCBI TaxId: 2643268
/// </summary>
public abstract class unclassified_Aetobatus : Aetobatus, Iunclassified_Aetobatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aetobatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643268;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aetobatus";
}
