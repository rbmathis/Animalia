using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Bachia;

/// <summary>
/// Abstract class for Bachia (genus).
/// NCBI TaxId: 174740
/// </summary>
public abstract class Bachia : Gymnophthalmidae, IBachia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bachia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174740;

    /// <inheritdoc />
    public virtual string GenusName => "Bachia";

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
