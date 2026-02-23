using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Hiodontiformes.Hiodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Hiodontiformes.Hiodontidae.Hiodon;

/// <summary>
/// Abstract class for Hiodon (genus).
/// NCBI TaxId: 54903
/// </summary>
public abstract class Hiodon : Hiodontidae, IHiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54903;

    /// <inheritdoc />
    public virtual string GenusName => "Hiodon";

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
