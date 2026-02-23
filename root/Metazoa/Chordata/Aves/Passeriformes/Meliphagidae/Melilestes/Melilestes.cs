using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Melilestes;

/// <summary>
/// Abstract class for Melilestes (genus).
/// NCBI TaxId: 266364
/// </summary>
public abstract class Melilestes : Meliphagidae, IMelilestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melilestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266364;

    /// <inheritdoc />
    public virtual string GenusName => "Melilestes";

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
