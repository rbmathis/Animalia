using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felis.unclassified_Felis;

/// <summary>
/// Abstract class for unclassified Felis (no rank).
/// NCBI TaxId: 2625412
/// </summary>
public abstract class unclassified_Felis : Felis, Iunclassified_Felis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Felis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625412;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Felis";
}
