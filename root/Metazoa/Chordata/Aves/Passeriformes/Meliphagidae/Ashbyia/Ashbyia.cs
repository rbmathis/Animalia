using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Ashbyia;

/// <summary>
/// Abstract class for Ashbyia (genus).
/// NCBI TaxId: 266338
/// </summary>
public abstract class Ashbyia : Meliphagidae, IAshbyia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ashbyia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266338;

    /// <inheritdoc />
    public virtual string GenusName => "Ashbyia";

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
