using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Belodontichthys;

/// <summary>
/// Abstract class for Belodontichthys (genus).
/// NCBI TaxId: 337742
/// </summary>
public abstract class Belodontichthys : Siluridae, IBelodontichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belodontichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337742;

    /// <inheritdoc />
    public virtual string GenusName => "Belodontichthys";

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
