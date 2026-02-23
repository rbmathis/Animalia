using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Drymodes;

/// <summary>
/// Abstract class for Drymodes (genus).
/// NCBI TaxId: 626377
/// </summary>
public abstract class Drymodes : Petroicidae, IDrymodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drymodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 626377;

    /// <inheritdoc />
    public virtual string GenusName => "Drymodes";

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
