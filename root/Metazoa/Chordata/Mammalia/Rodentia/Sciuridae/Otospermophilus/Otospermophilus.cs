using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Otospermophilus;

/// <summary>
/// Abstract class for Otospermophilus (genus).
/// NCBI TaxId: 1048899
/// </summary>
public abstract class Otospermophilus : Sciuridae, IOtospermophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otospermophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1048899;

    /// <inheritdoc />
    public virtual string GenusName => "Otospermophilus";

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
