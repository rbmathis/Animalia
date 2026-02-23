using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Ichthyocampus;

/// <summary>
/// Abstract class for Ichthyocampus (genus).
/// NCBI TaxId: 2593189
/// </summary>
public abstract class Ichthyocampus : Syngnathidae, IIchthyocampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichthyocampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2593189;

    /// <inheritdoc />
    public virtual string GenusName => "Ichthyocampus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
