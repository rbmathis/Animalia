using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Chrysiptera;

/// <summary>
/// Abstract class for Chrysiptera (genus).
/// NCBI TaxId: 80978
/// </summary>
public abstract class Chrysiptera : Pomacentridae, IChrysiptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysiptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80978;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysiptera";

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
