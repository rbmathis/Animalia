using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pseudacris;

/// <summary>
/// Abstract class for Pseudacris (genus).
/// NCBI TaxId: 189919
/// </summary>
public abstract class Pseudacris : Hylidae, IPseudacris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudacris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189919;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudacris";

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
