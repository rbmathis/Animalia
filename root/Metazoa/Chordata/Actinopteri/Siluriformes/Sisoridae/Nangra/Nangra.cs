using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Nangra;

/// <summary>
/// Abstract class for Nangra (genus).
/// NCBI TaxId: 337644
/// </summary>
public abstract class Nangra : Sisoridae, INangra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nangra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337644;

    /// <inheritdoc />
    public virtual string GenusName => "Nangra";

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
