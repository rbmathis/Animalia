using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Teixeirichthys;

/// <summary>
/// Abstract class for Teixeirichthys (genus).
/// NCBI TaxId: 80997
/// </summary>
public abstract class Teixeirichthys : Pomacentridae, ITeixeirichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Teixeirichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80997;

    /// <inheritdoc />
    public virtual string GenusName => "Teixeirichthys";

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
