using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Mussurana;

/// <summary>
/// Abstract class for Mussurana (genus).
/// NCBI TaxId: 1390248
/// </summary>
public abstract class Mussurana : Dipsadidae, IMussurana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mussurana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1390248;

    /// <inheritdoc />
    public virtual string GenusName => "Mussurana";

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
