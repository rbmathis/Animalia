using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.unclassified_Felidae;

/// <summary>
/// Abstract class for unclassified Felidae (no rank).
/// NCBI TaxId: 339610
/// </summary>
public abstract class unclassified_Felidae : Felidae, Iunclassified_Felidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Felidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 339610;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Felidae";
}
