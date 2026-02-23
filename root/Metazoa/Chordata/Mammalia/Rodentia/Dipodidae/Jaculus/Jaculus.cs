using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Jaculus;

/// <summary>
/// Abstract class for Jaculus (genus).
/// NCBI TaxId: 48867
/// </summary>
public abstract class Jaculus : Dipodidae, IJaculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jaculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48867;

    /// <inheritdoc />
    public virtual string GenusName => "Jaculus";

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
