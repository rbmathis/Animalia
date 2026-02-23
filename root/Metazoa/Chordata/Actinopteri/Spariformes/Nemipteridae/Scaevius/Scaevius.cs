using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Scaevius;

/// <summary>
/// Abstract class for Scaevius (genus).
/// NCBI TaxId: 1982623
/// </summary>
public abstract class Scaevius : Nemipteridae, IScaevius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaevius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1982623;

    /// <inheritdoc />
    public virtual string GenusName => "Scaevius";

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
