using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.unclassified_Procyonidae;

/// <summary>
/// Abstract class for unclassified Procyonidae (no rank).
/// NCBI TaxId: 1967461
/// </summary>
public abstract class unclassified_Procyonidae : Procyonidae, Iunclassified_Procyonidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Procyonidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1967461;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Procyonidae";
}
