using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Platichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Platichthys.unclassified_Platichthys;

/// <summary>
/// Abstract class for unclassified Platichthys (no rank).
/// NCBI TaxId: 2617899
/// </summary>
public abstract class unclassified_Platichthys : Platichthys, Iunclassified_Platichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617899;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platichthys";
}
