using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Mergellus;

/// <summary>
/// Abstract class for Mergellus (genus).
/// NCBI TaxId: 107025
/// </summary>
public abstract class Mergellus : Anatidae, IMergellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mergellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107025;

    /// <inheritdoc />
    public virtual string GenusName => "Mergellus";

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
