using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Typhlobelus;

/// <summary>
/// Abstract class for Typhlobelus (genus).
/// NCBI TaxId: 648148
/// </summary>
public abstract class Typhlobelus : Trichomycteridae, ITyphlobelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlobelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 648148;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlobelus";

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
