using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Silverstoneia;

/// <summary>
/// Abstract class for Silverstoneia (genus).
/// NCBI TaxId: 507707
/// </summary>
public abstract class Silverstoneia : Dendrobatidae, ISilverstoneia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Silverstoneia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 507707;

    /// <inheritdoc />
    public virtual string GenusName => "Silverstoneia";

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
