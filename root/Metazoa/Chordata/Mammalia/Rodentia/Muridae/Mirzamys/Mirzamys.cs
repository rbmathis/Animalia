using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mirzamys;

/// <summary>
/// Abstract class for Mirzamys (genus).
/// NCBI TaxId: 3148841
/// </summary>
public abstract class Mirzamys : Muridae, IMirzamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mirzamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148841;

    /// <inheritdoc />
    public virtual string GenusName => "Mirzamys";

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
