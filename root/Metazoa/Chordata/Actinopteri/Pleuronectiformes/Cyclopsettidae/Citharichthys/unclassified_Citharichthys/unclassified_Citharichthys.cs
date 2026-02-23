using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Citharichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Citharichthys.unclassified_Citharichthys;

/// <summary>
/// Abstract class for unclassified Citharichthys (no rank).
/// NCBI TaxId: 2634633
/// </summary>
public abstract class unclassified_Citharichthys : Citharichthys, Iunclassified_Citharichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Citharichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634633;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Citharichthys";
}
