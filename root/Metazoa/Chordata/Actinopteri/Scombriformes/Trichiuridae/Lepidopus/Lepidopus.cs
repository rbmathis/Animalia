using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Lepidopus;

/// <summary>
/// Abstract class for Lepidopus (genus).
/// NCBI TaxId: 107244
/// </summary>
public abstract class Lepidopus : Trichiuridae, ILepidopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107244;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidopus";

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
