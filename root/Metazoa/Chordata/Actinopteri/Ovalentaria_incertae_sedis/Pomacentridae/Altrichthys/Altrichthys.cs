using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Altrichthys;

/// <summary>
/// Abstract class for Altrichthys (genus).
/// NCBI TaxId: 646036
/// </summary>
public abstract class Altrichthys : Pomacentridae, IAltrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Altrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 646036;

    /// <inheritdoc />
    public virtual string GenusName => "Altrichthys";

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
