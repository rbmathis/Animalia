using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Sphyrapicus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Sphyrapicus.unclassified_Sphyrapicus;

/// <summary>
/// Abstract class for unclassified Sphyrapicus (no rank).
/// NCBI TaxId: 2975256
/// </summary>
public abstract class unclassified_Sphyrapicus : Sphyrapicus, Iunclassified_Sphyrapicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sphyrapicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2975256;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sphyrapicus";
}
