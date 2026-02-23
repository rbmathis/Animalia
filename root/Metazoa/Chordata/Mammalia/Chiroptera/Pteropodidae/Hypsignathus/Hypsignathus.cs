using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Hypsignathus;

/// <summary>
/// Abstract class for Hypsignathus (genus).
/// NCBI TaxId: 448083
/// </summary>
public abstract class Hypsignathus : Pteropodidae, IHypsignathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsignathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 448083;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsignathus";

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
