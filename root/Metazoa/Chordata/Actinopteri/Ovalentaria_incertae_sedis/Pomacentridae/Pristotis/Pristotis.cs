using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Pristotis;

/// <summary>
/// Abstract class for Pristotis (genus).
/// NCBI TaxId: 446805
/// </summary>
public abstract class Pristotis : Pomacentridae, IPristotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446805;

    /// <inheritdoc />
    public virtual string GenusName => "Pristotis";

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
