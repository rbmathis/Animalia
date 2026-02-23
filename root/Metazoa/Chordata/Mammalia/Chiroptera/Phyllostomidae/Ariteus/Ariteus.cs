using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Ariteus;

/// <summary>
/// Abstract class for Ariteus (genus).
/// NCBI TaxId: 148024
/// </summary>
public abstract class Ariteus : Phyllostomidae, IAriteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ariteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148024;

    /// <inheritdoc />
    public virtual string GenusName => "Ariteus";

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
