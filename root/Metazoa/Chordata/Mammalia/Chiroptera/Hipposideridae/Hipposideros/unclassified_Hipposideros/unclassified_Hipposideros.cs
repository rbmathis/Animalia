using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae.Hipposideros;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae.Hipposideros.unclassified_Hipposideros;

/// <summary>
/// Abstract class for unclassified Hipposideros (no rank).
/// NCBI TaxId: 2646091
/// </summary>
public abstract class unclassified_Hipposideros : Hipposideros, Iunclassified_Hipposideros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hipposideros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646091;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hipposideros";
}
