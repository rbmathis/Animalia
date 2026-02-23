using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Similiparma;

/// <summary>
/// Abstract class for Similiparma (genus).
/// NCBI TaxId: 646048
/// </summary>
public abstract class Similiparma : Pomacentridae, ISimiliparma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Similiparma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 646048;

    /// <inheritdoc />
    public virtual string GenusName => "Similiparma";

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
