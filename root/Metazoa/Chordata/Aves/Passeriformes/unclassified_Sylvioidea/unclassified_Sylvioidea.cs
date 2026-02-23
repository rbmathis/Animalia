using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.unclassified_Sylvioidea;

/// <summary>
/// Abstract class for unclassified Sylvioidea (no rank).
/// NCBI TaxId: 2661689
/// </summary>
public abstract class unclassified_Sylvioidea : Passeriformes, Iunclassified_Sylvioidea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sylvioidea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2661689;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sylvioidea";
}
