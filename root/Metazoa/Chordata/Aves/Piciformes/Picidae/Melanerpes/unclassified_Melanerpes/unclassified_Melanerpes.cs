using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Melanerpes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Melanerpes.unclassified_Melanerpes;

/// <summary>
/// Abstract class for unclassified Melanerpes (no rank).
/// NCBI TaxId: 2878401
/// </summary>
public abstract class unclassified_Melanerpes : Melanerpes, Iunclassified_Melanerpes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melanerpes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878401;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melanerpes";
}
