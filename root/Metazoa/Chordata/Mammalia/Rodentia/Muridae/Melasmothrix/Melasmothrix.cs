using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Melasmothrix;

/// <summary>
/// Abstract class for Melasmothrix (genus).
/// NCBI TaxId: 491875
/// </summary>
public abstract class Melasmothrix : Muridae, IMelasmothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melasmothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 491875;

    /// <inheritdoc />
    public virtual string GenusName => "Melasmothrix";

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
