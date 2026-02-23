using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Melanopareia;

/// <summary>
/// Abstract class for Melanopareia (genus).
/// NCBI TaxId: 30441
/// </summary>
public abstract class Melanopareia : Rhinocryptidae, IMelanopareia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanopareia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30441;

    /// <inheritdoc />
    public virtual string GenusName => "Melanopareia";

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
