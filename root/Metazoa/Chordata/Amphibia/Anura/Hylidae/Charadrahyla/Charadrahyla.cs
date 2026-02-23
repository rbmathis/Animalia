using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Charadrahyla;

/// <summary>
/// Abstract class for Charadrahyla (genus).
/// NCBI TaxId: 374080
/// </summary>
public abstract class Charadrahyla : Hylidae, ICharadrahyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Charadrahyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374080;

    /// <inheritdoc />
    public virtual string GenusName => "Charadrahyla";

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
