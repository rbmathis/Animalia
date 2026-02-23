using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae.Proteles;

/// <summary>
/// Abstract class for Proteles (genus).
/// NCBI TaxId: 9679
/// </summary>
public abstract class Proteles : Hyaenidae, IProteles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proteles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9679;

    /// <inheritdoc />
    public virtual string GenusName => "Proteles";

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
