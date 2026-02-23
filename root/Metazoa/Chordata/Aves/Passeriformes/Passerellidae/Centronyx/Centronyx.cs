using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Centronyx;

/// <summary>
/// Abstract class for Centronyx (genus).
/// NCBI TaxId: 2518005
/// </summary>
public abstract class Centronyx : Passerellidae, ICentronyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centronyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2518005;

    /// <inheritdoc />
    public virtual string GenusName => "Centronyx";

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
