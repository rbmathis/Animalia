using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Mancopsetta;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Mancopsetta.unclassified_Mancopsetta;

/// <summary>
/// Abstract class for unclassified Mancopsetta (no rank).
/// NCBI TaxId: 2649016
/// </summary>
public abstract class unclassified_Mancopsetta : Mancopsetta, Iunclassified_Mancopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mancopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649016;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mancopsetta";
}
