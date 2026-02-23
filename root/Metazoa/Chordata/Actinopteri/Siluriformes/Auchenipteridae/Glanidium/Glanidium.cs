using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Glanidium;

/// <summary>
/// Abstract class for Glanidium (genus).
/// NCBI TaxId: 756479
/// </summary>
public abstract class Glanidium : Auchenipteridae, IGlanidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glanidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 756479;

    /// <inheritdoc />
    public virtual string GenusName => "Glanidium";

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
