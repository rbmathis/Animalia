using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Pterocryptis;

/// <summary>
/// Abstract class for Pterocryptis (genus).
/// NCBI TaxId: 175795
/// </summary>
public abstract class Pterocryptis : Siluridae, IPterocryptis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterocryptis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175795;

    /// <inheritdoc />
    public virtual string GenusName => "Pterocryptis";

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
