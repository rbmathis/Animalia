using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Aphelocoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Aphelocoma.unclassified_Aphelocoma;

/// <summary>
/// Abstract class for unclassified Aphelocoma (no rank).
/// NCBI TaxId: 2878759
/// </summary>
public abstract class unclassified_Aphelocoma : Aphelocoma, Iunclassified_Aphelocoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aphelocoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878759;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aphelocoma";
}
