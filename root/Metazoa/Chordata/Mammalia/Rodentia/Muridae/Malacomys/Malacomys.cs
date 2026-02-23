using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Malacomys;

/// <summary>
/// Abstract class for Malacomys (genus).
/// NCBI TaxId: 112225
/// </summary>
public abstract class Malacomys : Muridae, IMalacomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 112225;

    /// <inheritdoc />
    public virtual string GenusName => "Malacomys";

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
