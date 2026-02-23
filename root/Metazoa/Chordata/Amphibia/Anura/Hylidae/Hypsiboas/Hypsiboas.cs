using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hypsiboas;

/// <summary>
/// Abstract class for Hypsiboas (genus).
/// NCBI TaxId: 356303
/// </summary>
public abstract class Hypsiboas : Hylidae, IHypsiboas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsiboas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356303;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsiboas";

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
