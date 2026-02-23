using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Cyclopsetta;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Cyclopsetta.unclassified_Cyclopsetta;

/// <summary>
/// Abstract class for unclassified Cyclopsetta (no rank).
/// NCBI TaxId: 3049909
/// </summary>
public abstract class unclassified_Cyclopsetta : Cyclopsetta, Iunclassified_Cyclopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyclopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049909;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyclopsetta";
}
