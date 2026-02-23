using AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae.Aechmophorus;

/// <summary>
/// Abstract class for Aechmophorus (genus).
/// NCBI TaxId: 57235
/// </summary>
public abstract class Aechmophorus : Podicipedidae, IAechmophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aechmophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57235;

    /// <inheritdoc />
    public virtual string GenusName => "Aechmophorus";

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
