using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Dischistodus;

/// <summary>
/// Abstract class for Dischistodus (genus).
/// NCBI TaxId: 196129
/// </summary>
public abstract class Dischistodus : Pomacentridae, IDischistodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dischistodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196129;

    /// <inheritdoc />
    public virtual string GenusName => "Dischistodus";

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
