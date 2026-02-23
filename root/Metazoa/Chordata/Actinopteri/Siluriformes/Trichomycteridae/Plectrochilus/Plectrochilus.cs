using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Plectrochilus;

/// <summary>
/// Abstract class for Plectrochilus (genus).
/// NCBI TaxId: 648142
/// </summary>
public abstract class Plectrochilus : Trichomycteridae, IPlectrochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectrochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 648142;

    /// <inheritdoc />
    public virtual string GenusName => "Plectrochilus";

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
