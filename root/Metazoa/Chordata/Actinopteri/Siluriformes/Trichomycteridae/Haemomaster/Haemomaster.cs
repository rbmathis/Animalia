using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Haemomaster;

/// <summary>
/// Abstract class for Haemomaster (genus).
/// NCBI TaxId: 648130
/// </summary>
public abstract class Haemomaster : Trichomycteridae, IHaemomaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haemomaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 648130;

    /// <inheritdoc />
    public virtual string GenusName => "Haemomaster";

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
