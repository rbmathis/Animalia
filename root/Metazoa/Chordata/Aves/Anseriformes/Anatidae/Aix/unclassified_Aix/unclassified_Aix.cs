using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Aix;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Aix.unclassified_Aix;

/// <summary>
/// Abstract class for unclassified Aix (no rank).
/// NCBI TaxId: 2646690
/// </summary>
public abstract class unclassified_Aix : Aix, Iunclassified_Aix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646690;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aix";
}
