using AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae.Podilymbus;

/// <summary>
/// Abstract class for Podilymbus (genus).
/// NCBI TaxId: 9251
/// </summary>
public abstract class Podilymbus : Podicipedidae, IPodilymbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Podilymbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9251;

    /// <inheritdoc />
    public virtual string GenusName => "Podilymbus";

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
