using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Urotheca;

/// <summary>
/// Abstract class for Urotheca (genus).
/// NCBI TaxId: 1212742
/// </summary>
public abstract class Urotheca : Dipsadidae, IUrotheca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urotheca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1212742;

    /// <inheritdoc />
    public virtual string GenusName => "Urotheca";

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
