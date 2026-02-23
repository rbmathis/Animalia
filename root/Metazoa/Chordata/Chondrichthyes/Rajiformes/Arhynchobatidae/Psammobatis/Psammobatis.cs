using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Psammobatis;

/// <summary>
/// Abstract class for Psammobatis (genus).
/// NCBI TaxId: 117874
/// </summary>
public abstract class Psammobatis : Arhynchobatidae, IPsammobatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psammobatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117874;

    /// <inheritdoc />
    public virtual string GenusName => "Psammobatis";

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
