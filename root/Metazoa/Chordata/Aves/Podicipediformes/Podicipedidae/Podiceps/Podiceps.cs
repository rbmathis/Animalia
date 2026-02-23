using AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Podicipediformes.Podicipedidae.Podiceps;

/// <summary>
/// Abstract class for Podiceps (genus).
/// NCBI TaxId: 37049
/// </summary>
public abstract class Podiceps : Podicipedidae, IPodiceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Podiceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37049;

    /// <inheritdoc />
    public virtual string GenusName => "Podiceps";

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
