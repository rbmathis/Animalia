using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Macrotus;

/// <summary>
/// Abstract class for Macrotus (genus).
/// NCBI TaxId: 9418
/// </summary>
public abstract class Macrotus : Phyllostomidae, IMacrotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9418;

    /// <inheritdoc />
    public virtual string GenusName => "Macrotus";

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
