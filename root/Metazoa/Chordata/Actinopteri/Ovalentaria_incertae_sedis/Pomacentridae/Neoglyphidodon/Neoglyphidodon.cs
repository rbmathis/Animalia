using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Neoglyphidodon;

/// <summary>
/// Abstract class for Neoglyphidodon (genus).
/// NCBI TaxId: 80981
/// </summary>
public abstract class Neoglyphidodon : Pomacentridae, INeoglyphidodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoglyphidodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80981;

    /// <inheritdoc />
    public virtual string GenusName => "Neoglyphidodon";

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
