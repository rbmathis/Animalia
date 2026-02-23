using AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae.Poliocephalus;

/// <summary>
/// Abstract class for Poliocephalus (genus).
/// NCBI TaxId: 2497797
/// </summary>
public abstract class Poliocephalus : Podicipedidae, IPoliocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poliocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2497797;

    /// <inheritdoc />
    public virtual string GenusName => "Poliocephalus";

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
