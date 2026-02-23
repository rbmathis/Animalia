using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Piculus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Piculus.unclassified_Piculus;

/// <summary>
/// Abstract class for unclassified Piculus (no rank).
/// NCBI TaxId: 2632324
/// </summary>
public abstract class unclassified_Piculus : Piculus, Iunclassified_Piculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Piculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632324;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Piculus";
}
