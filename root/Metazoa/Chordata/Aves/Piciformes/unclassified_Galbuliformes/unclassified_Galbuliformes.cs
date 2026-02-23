using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.unclassified_Galbuliformes;

/// <summary>
/// Abstract class for unclassified Galbuliformes (no rank).
/// NCBI TaxId: 791196
/// </summary>
public abstract class unclassified_Galbuliformes : Piciformes, Iunclassified_Galbuliformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Galbuliformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 791196;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Galbuliformes";
}
