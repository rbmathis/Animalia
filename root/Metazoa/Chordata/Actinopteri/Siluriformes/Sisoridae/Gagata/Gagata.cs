using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Gagata;

/// <summary>
/// Abstract class for Gagata (genus).
/// NCBI TaxId: 205339
/// </summary>
public abstract class Gagata : Sisoridae, IGagata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gagata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205339;

    /// <inheritdoc />
    public virtual string GenusName => "Gagata";

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
