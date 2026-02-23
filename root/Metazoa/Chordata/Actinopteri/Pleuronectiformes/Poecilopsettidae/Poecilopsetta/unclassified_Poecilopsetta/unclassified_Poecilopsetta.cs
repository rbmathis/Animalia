using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Poecilopsettidae.Poecilopsetta;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Poecilopsettidae.Poecilopsetta.unclassified_Poecilopsetta;

/// <summary>
/// Abstract class for unclassified Poecilopsetta (no rank).
/// NCBI TaxId: 2726552
/// </summary>
public abstract class unclassified_Poecilopsetta : Poecilopsetta, Iunclassified_Poecilopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Poecilopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726552;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Poecilopsetta";
}
