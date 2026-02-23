using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Malacopteron;

/// <summary>
/// Abstract class for Malacopteron (genus).
/// NCBI TaxId: 201342
/// </summary>
public abstract class Malacopteron : Timaliidae, IMalacopteron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacopteron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201342;

    /// <inheritdoc />
    public virtual string GenusName => "Malacopteron";

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
