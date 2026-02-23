using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petaurillus;

/// <summary>
/// Abstract class for Petaurillus (genus).
/// NCBI TaxId: 226814
/// </summary>
public abstract class Petaurillus : Sciuridae, IPetaurillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petaurillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226814;

    /// <inheritdoc />
    public virtual string GenusName => "Petaurillus";

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
