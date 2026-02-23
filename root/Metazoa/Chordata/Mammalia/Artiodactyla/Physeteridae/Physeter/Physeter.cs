using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Physeteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Physeteridae.Physeter;

/// <summary>
/// Abstract class for Physeter (genus).
/// NCBI TaxId: 9753
/// </summary>
public abstract class Physeter : Physeteridae, IPhyseter
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Physeter";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9753;

    /// <inheritdoc />
    public virtual string GenusName => "Physeter";

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
