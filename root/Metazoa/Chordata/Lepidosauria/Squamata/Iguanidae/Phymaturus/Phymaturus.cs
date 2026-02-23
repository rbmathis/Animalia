using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Phymaturus;

/// <summary>
/// Abstract class for Phymaturus (genus).
/// NCBI TaxId: 81830
/// </summary>
public abstract class Phymaturus : Iguanidae, IPhymaturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phymaturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81830;

    /// <inheritdoc />
    public virtual string GenusName => "Phymaturus";

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
