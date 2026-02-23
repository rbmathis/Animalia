using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Lepidozygus;

/// <summary>
/// Abstract class for Lepidozygus (genus).
/// NCBI TaxId: 646044
/// </summary>
public abstract class Lepidozygus : Pomacentridae, ILepidozygus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidozygus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 646044;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidozygus";

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
