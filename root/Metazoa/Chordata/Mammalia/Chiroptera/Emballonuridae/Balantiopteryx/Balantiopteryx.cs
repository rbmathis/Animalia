using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Balantiopteryx;

/// <summary>
/// Abstract class for Balantiopteryx (genus).
/// NCBI TaxId: 148079
/// </summary>
public abstract class Balantiopteryx : Emballonuridae, IBalantiopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balantiopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148079;

    /// <inheritdoc />
    public virtual string GenusName => "Balantiopteryx";

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
