using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Hypsypops;

/// <summary>
/// Abstract class for Hypsypops (genus).
/// NCBI TaxId: 161904
/// </summary>
public abstract class Hypsypops : Pomacentridae, IHypsypops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsypops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161904;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsypops";

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
