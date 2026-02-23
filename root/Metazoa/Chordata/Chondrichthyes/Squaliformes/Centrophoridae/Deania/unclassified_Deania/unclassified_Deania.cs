using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae.Deania;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae.Deania.unclassified_Deania;

/// <summary>
/// Abstract class for unclassified Deania (no rank).
/// NCBI TaxId: 2623447
/// </summary>
public abstract class unclassified_Deania : Deania, Iunclassified_Deania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Deania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623447;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Deania";
}
