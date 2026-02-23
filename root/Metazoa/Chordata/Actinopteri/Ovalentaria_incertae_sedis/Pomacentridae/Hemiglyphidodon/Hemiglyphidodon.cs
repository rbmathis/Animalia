using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Hemiglyphidodon;

/// <summary>
/// Abstract class for Hemiglyphidodon (genus).
/// NCBI TaxId: 229124
/// </summary>
public abstract class Hemiglyphidodon : Pomacentridae, IHemiglyphidodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiglyphidodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 229124;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiglyphidodon";

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
