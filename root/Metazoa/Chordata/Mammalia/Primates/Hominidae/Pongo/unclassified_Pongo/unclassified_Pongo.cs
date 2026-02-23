using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pongo;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pongo.unclassified_Pongo;

/// <summary>
/// Abstract class for unclassified Pongo (no rank).
/// NCBI TaxId: 2624844
/// </summary>
public abstract class unclassified_Pongo : Pongo, Iunclassified_Pongo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pongo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624844;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pongo";
}
