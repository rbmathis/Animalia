using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Kareius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Kareius.unclassified_Kareius;

/// <summary>
/// Abstract class for unclassified Kareius (no rank).
/// NCBI TaxId: 2909758
/// </summary>
public abstract class unclassified_Kareius : Kareius, Iunclassified_Kareius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kareius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2909758;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kareius";
}
