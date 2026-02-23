using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Silvinichthys;

/// <summary>
/// Abstract class for Silvinichthys (genus).
/// NCBI TaxId: 2807481
/// </summary>
public abstract class Silvinichthys : Trichomycteridae, ISilvinichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Silvinichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2807481;

    /// <inheritdoc />
    public virtual string GenusName => "Silvinichthys";

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
