using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus.unclassified_Squalus;

/// <summary>
/// Abstract class for unclassified Squalus (no rank).
/// NCBI TaxId: 2628936
/// </summary>
public abstract class unclassified_Squalus : Squalus, Iunclassified_Squalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Squalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628936;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Squalus";
}
