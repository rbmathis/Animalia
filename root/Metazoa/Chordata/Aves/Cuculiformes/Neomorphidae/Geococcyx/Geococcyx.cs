using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Neomorphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Neomorphidae.Geococcyx;

/// <summary>
/// Abstract class for Geococcyx (genus).
/// NCBI TaxId: 8946
/// </summary>
public abstract class Geococcyx : Neomorphidae, IGeococcyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geococcyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8946;

    /// <inheritdoc />
    public virtual string GenusName => "Geococcyx";

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
