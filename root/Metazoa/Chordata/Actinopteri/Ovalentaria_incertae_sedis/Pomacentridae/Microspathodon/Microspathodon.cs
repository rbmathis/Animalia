using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Microspathodon;

/// <summary>
/// Abstract class for Microspathodon (genus).
/// NCBI TaxId: 161908
/// </summary>
public abstract class Microspathodon : Pomacentridae, IMicrospathodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microspathodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161908;

    /// <inheritdoc />
    public virtual string GenusName => "Microspathodon";

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
