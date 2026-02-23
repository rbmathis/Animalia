using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Lepidopsetta;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Lepidopsetta.unclassified_Lepidopsetta;

/// <summary>
/// Abstract class for unclassified Lepidopsetta (no rank).
/// NCBI TaxId: 3049929
/// </summary>
public abstract class unclassified_Lepidopsetta : Lepidopsetta, Iunclassified_Lepidopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049929;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidopsetta";
}
