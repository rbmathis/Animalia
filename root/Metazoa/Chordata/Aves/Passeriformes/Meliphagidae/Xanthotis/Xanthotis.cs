using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Xanthotis;

/// <summary>
/// Abstract class for Xanthotis (genus).
/// NCBI TaxId: 266388
/// </summary>
public abstract class Xanthotis : Meliphagidae, IXanthotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xanthotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266388;

    /// <inheritdoc />
    public virtual string GenusName => "Xanthotis";

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
