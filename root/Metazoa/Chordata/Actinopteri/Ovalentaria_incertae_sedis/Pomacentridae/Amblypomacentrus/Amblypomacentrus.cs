using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Amblypomacentrus;

/// <summary>
/// Abstract class for Amblypomacentrus (genus).
/// NCBI TaxId: 646038
/// </summary>
public abstract class Amblypomacentrus : Pomacentridae, IAmblypomacentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblypomacentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 646038;

    /// <inheritdoc />
    public virtual string GenusName => "Amblypomacentrus";

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
