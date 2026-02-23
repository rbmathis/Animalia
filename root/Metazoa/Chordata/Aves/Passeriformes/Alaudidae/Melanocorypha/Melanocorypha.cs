using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Melanocorypha;

/// <summary>
/// Abstract class for Melanocorypha (genus).
/// NCBI TaxId: 589657
/// </summary>
public abstract class Melanocorypha : Alaudidae, IMelanocorypha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanocorypha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589657;

    /// <inheritdoc />
    public virtual string GenusName => "Melanocorypha";

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
