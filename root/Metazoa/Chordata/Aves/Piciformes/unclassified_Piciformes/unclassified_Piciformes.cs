using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.unclassified_Piciformes;

/// <summary>
/// Abstract class for unclassified Piciformes (no rank).
/// NCBI TaxId: 772022
/// </summary>
public abstract class unclassified_Piciformes : Piciformes, Iunclassified_Piciformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Piciformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 772022;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Piciformes";
}
