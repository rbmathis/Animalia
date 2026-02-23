using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Homodiaetus;

/// <summary>
/// Abstract class for Homodiaetus (genus).
/// NCBI TaxId: 648132
/// </summary>
public abstract class Homodiaetus : Trichomycteridae, IHomodiaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homodiaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 648132;

    /// <inheritdoc />
    public virtual string GenusName => "Homodiaetus";

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
