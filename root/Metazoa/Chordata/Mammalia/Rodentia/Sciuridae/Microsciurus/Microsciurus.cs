using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Microsciurus;

/// <summary>
/// Abstract class for Microsciurus (genus).
/// NCBI TaxId: 45476
/// </summary>
public abstract class Microsciurus : Sciuridae, IMicrosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microsciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45476;

    /// <inheritdoc />
    public virtual string GenusName => "Microsciurus";

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
