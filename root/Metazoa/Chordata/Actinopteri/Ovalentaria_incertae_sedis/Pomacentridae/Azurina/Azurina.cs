using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Azurina;

/// <summary>
/// Abstract class for Azurina (genus).
/// NCBI TaxId: 196126
/// </summary>
public abstract class Azurina : Pomacentridae, IAzurina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Azurina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196126;

    /// <inheritdoc />
    public virtual string GenusName => "Azurina";

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
