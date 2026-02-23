using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Genetta;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Genetta.unclassified_Genetta;

/// <summary>
/// Abstract class for unclassified Genetta (no rank).
/// NCBI TaxId: 2645884
/// </summary>
public abstract class unclassified_Genetta : Genetta, Iunclassified_Genetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Genetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645884;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Genetta";
}
