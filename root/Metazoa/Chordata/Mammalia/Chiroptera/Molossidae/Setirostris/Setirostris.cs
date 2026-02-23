using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Setirostris;

/// <summary>
/// Abstract class for Setirostris (genus).
/// NCBI TaxId: 3371055
/// </summary>
public abstract class Setirostris : Molossidae, ISetirostris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Setirostris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371055;

    /// <inheritdoc />
    public virtual string GenusName => "Setirostris";

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
