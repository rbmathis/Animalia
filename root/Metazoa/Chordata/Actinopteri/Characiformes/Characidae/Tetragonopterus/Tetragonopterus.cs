using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Tetragonopterus;

/// <summary>
/// Abstract class for Tetragonopterus (genus).
/// NCBI TaxId: 42598
/// </summary>
public abstract class Tetragonopterus : Characidae, ITetragonopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetragonopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42598;

    /// <inheritdoc />
    public virtual string GenusName => "Tetragonopterus";

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
