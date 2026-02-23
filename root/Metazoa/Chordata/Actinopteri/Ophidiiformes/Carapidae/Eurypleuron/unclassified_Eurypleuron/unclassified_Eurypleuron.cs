using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Eurypleuron;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Eurypleuron.unclassified_Eurypleuron;

/// <summary>
/// Abstract class for unclassified Eurypleuron (no rank).
/// NCBI TaxId: 3095277
/// </summary>
public abstract class unclassified_Eurypleuron : Eurypleuron, Iunclassified_Eurypleuron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eurypleuron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3095277;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eurypleuron";
}
