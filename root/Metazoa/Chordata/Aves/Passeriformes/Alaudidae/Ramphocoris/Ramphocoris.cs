using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Ramphocoris;

/// <summary>
/// Abstract class for Ramphocoris (genus).
/// NCBI TaxId: 1365199
/// </summary>
public abstract class Ramphocoris : Alaudidae, IRamphocoris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramphocoris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365199;

    /// <inheritdoc />
    public virtual string GenusName => "Ramphocoris";

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
