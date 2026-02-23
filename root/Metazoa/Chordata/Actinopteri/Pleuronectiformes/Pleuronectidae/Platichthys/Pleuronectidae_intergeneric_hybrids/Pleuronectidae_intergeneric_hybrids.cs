using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Platichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Platichthys.Pleuronectidae_intergeneric_hybrids;

/// <summary>
/// Abstract class for Pleuronectidae intergeneric hybrids (no rank).
/// NCBI TaxId: 3070151
/// </summary>
public abstract class Pleuronectidae_intergeneric_hybrids : Platichthys, IPleuronectidae_intergeneric_hybrids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pleuronectidae intergeneric hybrids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3070151;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Pleuronectidae_intergeneric_hybrids";
}
