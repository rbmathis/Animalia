using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Ammoglanis;

/// <summary>
/// Abstract class for Ammoglanis (genus).
/// NCBI TaxId: 2809285
/// </summary>
public abstract class Ammoglanis : Trichomycteridae, IAmmoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2809285;

    /// <inheritdoc />
    public virtual string GenusName => "Ammoglanis";

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
