using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Mastigodryas;

/// <summary>
/// Abstract class for Mastigodryas (genus).
/// NCBI TaxId: 121351
/// </summary>
public abstract class Mastigodryas : Colubridae, IMastigodryas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mastigodryas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121351;

    /// <inheritdoc />
    public virtual string GenusName => "Mastigodryas";

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
