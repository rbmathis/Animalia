using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Trichodere;

/// <summary>
/// Abstract class for Trichodere (genus).
/// NCBI TaxId: 266384
/// </summary>
public abstract class Trichodere : Meliphagidae, ITrichodere
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichodere";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266384;

    /// <inheritdoc />
    public virtual string GenusName => "Trichodere";

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
