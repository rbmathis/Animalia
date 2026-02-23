using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Plectroglyphidodon;

/// <summary>
/// Abstract class for Plectroglyphidodon (genus).
/// NCBI TaxId: 80986
/// </summary>
public abstract class Plectroglyphidodon : Pomacentridae, IPlectroglyphidodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectroglyphidodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80986;

    /// <inheritdoc />
    public virtual string GenusName => "Plectroglyphidodon";

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
