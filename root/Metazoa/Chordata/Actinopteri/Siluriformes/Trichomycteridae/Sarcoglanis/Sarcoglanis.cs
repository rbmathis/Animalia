using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Sarcoglanis;

/// <summary>
/// Abstract class for Sarcoglanis (genus).
/// NCBI TaxId: 648146
/// </summary>
public abstract class Sarcoglanis : Trichomycteridae, ISarcoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarcoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 648146;

    /// <inheritdoc />
    public virtual string GenusName => "Sarcoglanis";

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
