using AnimalKingdom.root.Metazoa.Chordata.Aves;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.unclassified_Aves;

/// <summary>
/// Abstract class for unclassified Aves (no rank).
/// NCBI TaxId: 1663348
/// </summary>
public abstract class unclassified_Aves : Aves, Iunclassified_Aves
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aves";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1663348;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aves";
}
