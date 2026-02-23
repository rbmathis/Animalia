using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Hatcheria;

/// <summary>
/// Abstract class for Hatcheria (genus).
/// NCBI TaxId: 337695
/// </summary>
public abstract class Hatcheria : Trichomycteridae, IHatcheria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hatcheria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337695;

    /// <inheritdoc />
    public virtual string GenusName => "Hatcheria";

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
