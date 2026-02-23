using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Stegastes;

/// <summary>
/// Abstract class for Stegastes (genus).
/// NCBI TaxId: 80992
/// </summary>
public abstract class Stegastes : Pomacentridae, IStegastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stegastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80992;

    /// <inheritdoc />
    public virtual string GenusName => "Stegastes";

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
