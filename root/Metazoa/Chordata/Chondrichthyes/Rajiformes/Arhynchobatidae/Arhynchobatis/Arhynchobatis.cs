using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Arhynchobatis;

/// <summary>
/// Abstract class for Arhynchobatis (genus).
/// NCBI TaxId: 117869
/// </summary>
public abstract class Arhynchobatis : Arhynchobatidae, IArhynchobatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arhynchobatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117869;

    /// <inheritdoc />
    public virtual string GenusName => "Arhynchobatis";

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
