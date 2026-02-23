using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Amastridium;

/// <summary>
/// Abstract class for Amastridium (genus).
/// NCBI TaxId: 697012
/// </summary>
public abstract class Amastridium : Dipsadidae, IAmastridium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amastridium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 697012;

    /// <inheritdoc />
    public virtual string GenusName => "Amastridium";

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
