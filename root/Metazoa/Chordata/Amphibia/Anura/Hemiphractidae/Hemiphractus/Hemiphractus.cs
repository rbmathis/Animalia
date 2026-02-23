using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Hemiphractus;

/// <summary>
/// Abstract class for Hemiphractus (genus).
/// NCBI TaxId: 317321
/// </summary>
public abstract class Hemiphractus : Hemiphractidae, IHemiphractus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiphractus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317321;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiphractus";

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
