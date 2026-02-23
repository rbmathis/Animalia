using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Saccopteryx;

/// <summary>
/// Abstract class for Saccopteryx (genus).
/// NCBI TaxId: 59481
/// </summary>
public abstract class Saccopteryx : Emballonuridae, ISaccopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saccopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59481;

    /// <inheritdoc />
    public virtual string GenusName => "Saccopteryx";

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
