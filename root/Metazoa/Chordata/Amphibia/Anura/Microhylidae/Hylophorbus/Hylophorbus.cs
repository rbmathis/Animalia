using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Hylophorbus;

/// <summary>
/// Abstract class for Hylophorbus (genus).
/// NCBI TaxId: 419648
/// </summary>
public abstract class Hylophorbus : Microhylidae, IHylophorbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylophorbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 419648;

    /// <inheritdoc />
    public virtual string GenusName => "Hylophorbus";

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
