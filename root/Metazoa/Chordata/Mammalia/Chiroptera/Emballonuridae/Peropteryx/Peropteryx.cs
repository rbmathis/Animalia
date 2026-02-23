using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Peropteryx;

/// <summary>
/// Abstract class for Peropteryx (genus).
/// NCBI TaxId: 249013
/// </summary>
public abstract class Peropteryx : Emballonuridae, IPeropteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peropteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 249013;

    /// <inheritdoc />
    public virtual string GenusName => "Peropteryx";

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
