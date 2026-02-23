using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Phycodurus;

/// <summary>
/// Abstract class for Phycodurus (genus).
/// NCBI TaxId: 693458
/// </summary>
public abstract class Phycodurus : Syngnathidae, IPhycodurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phycodurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 693458;

    /// <inheritdoc />
    public virtual string GenusName => "Phycodurus";

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
