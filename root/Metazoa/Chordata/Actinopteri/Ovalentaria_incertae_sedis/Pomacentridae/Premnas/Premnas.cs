using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Premnas;

/// <summary>
/// Abstract class for Premnas (genus).
/// NCBI TaxId: 80990
/// </summary>
public abstract class Premnas : Pomacentridae, IPremnas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Premnas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80990;

    /// <inheritdoc />
    public virtual string GenusName => "Premnas";

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
