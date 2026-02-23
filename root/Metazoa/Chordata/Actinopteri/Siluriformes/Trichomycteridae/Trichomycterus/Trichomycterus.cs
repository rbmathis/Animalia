using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Trichomycterus;

/// <summary>
/// Abstract class for Trichomycterus (genus).
/// NCBI TaxId: 36719
/// </summary>
public abstract class Trichomycterus : Trichomycteridae, ITrichomycterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichomycterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36719;

    /// <inheritdoc />
    public virtual string GenusName => "Trichomycterus";

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
