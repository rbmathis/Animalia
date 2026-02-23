using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Stegophilus;

/// <summary>
/// Abstract class for Stegophilus (genus).
/// NCBI TaxId: 2023048
/// </summary>
public abstract class Stegophilus : Trichomycteridae, IStegophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stegophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2023048;

    /// <inheritdoc />
    public virtual string GenusName => "Stegophilus";

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
