using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Symposiachrus;

/// <summary>
/// Abstract class for Symposiachrus (genus).
/// NCBI TaxId: 1576457
/// </summary>
public abstract class Symposiachrus : Monarchidae, ISymposiachrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Symposiachrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1576457;

    /// <inheritdoc />
    public virtual string GenusName => "Symposiachrus";

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
