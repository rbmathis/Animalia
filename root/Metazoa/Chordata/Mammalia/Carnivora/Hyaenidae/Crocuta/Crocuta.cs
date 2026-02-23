using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae.Crocuta;

/// <summary>
/// Abstract class for Crocuta (genus).
/// NCBI TaxId: 9677
/// </summary>
public abstract class Crocuta : Hyaenidae, ICrocuta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crocuta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9677;

    /// <inheritdoc />
    public virtual string GenusName => "Crocuta";

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
