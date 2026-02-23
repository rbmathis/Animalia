using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Epixerus;

/// <summary>
/// Abstract class for Epixerus (genus).
/// NCBI TaxId: 226682
/// </summary>
public abstract class Epixerus : Sciuridae, IEpixerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epixerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226682;

    /// <inheritdoc />
    public virtual string GenusName => "Epixerus";

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
