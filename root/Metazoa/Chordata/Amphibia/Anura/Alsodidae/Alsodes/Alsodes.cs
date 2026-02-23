using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Alsodes;

/// <summary>
/// Abstract class for Alsodes (genus).
/// NCBI TaxId: 209674
/// </summary>
public abstract class Alsodes : Alsodidae, IAlsodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alsodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209674;

    /// <inheritdoc />
    public virtual string GenusName => "Alsodes";

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
