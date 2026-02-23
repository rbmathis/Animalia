using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Dascyllus;

/// <summary>
/// Abstract class for Dascyllus (genus).
/// NCBI TaxId: 50744
/// </summary>
public abstract class Dascyllus : Pomacentridae, IDascyllus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dascyllus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50744;

    /// <inheritdoc />
    public virtual string GenusName => "Dascyllus";

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
