using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Neopomacentrus;

/// <summary>
/// Abstract class for Neopomacentrus (genus).
/// NCBI TaxId: 80984
/// </summary>
public abstract class Neopomacentrus : Pomacentridae, INeopomacentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neopomacentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80984;

    /// <inheritdoc />
    public virtual string GenusName => "Neopomacentrus";

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
