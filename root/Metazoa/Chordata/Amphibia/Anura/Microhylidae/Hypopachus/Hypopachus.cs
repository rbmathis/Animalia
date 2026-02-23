using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Hypopachus;

/// <summary>
/// Abstract class for Hypopachus (genus).
/// NCBI TaxId: 445152
/// </summary>
public abstract class Hypopachus : Microhylidae, IHypopachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypopachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 445152;

    /// <inheritdoc />
    public virtual string GenusName => "Hypopachus";

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
