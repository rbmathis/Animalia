using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Tepuihyla;

/// <summary>
/// Abstract class for Tepuihyla (genus).
/// NCBI TaxId: 318412
/// </summary>
public abstract class Tepuihyla : Hylidae, ITepuihyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tepuihyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318412;

    /// <inheritdoc />
    public virtual string GenusName => "Tepuihyla";

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
