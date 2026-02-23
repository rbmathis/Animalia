using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Centurio;

/// <summary>
/// Abstract class for Centurio (genus).
/// NCBI TaxId: 27643
/// </summary>
public abstract class Centurio : Phyllostomidae, ICenturio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centurio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27643;

    /// <inheritdoc />
    public virtual string GenusName => "Centurio";

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
