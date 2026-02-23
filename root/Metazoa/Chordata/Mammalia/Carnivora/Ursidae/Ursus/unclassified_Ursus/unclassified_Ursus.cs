using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Ursus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Ursus.unclassified_Ursus;

/// <summary>
/// Abstract class for unclassified Ursus (no rank).
/// NCBI TaxId: 2623310
/// </summary>
public abstract class unclassified_Ursus : Ursus, Iunclassified_Ursus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ursus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623310;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ursus";
}
