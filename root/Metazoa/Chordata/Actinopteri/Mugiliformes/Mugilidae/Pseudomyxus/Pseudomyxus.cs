using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Pseudomyxus;

/// <summary>
/// Abstract class for Pseudomyxus (genus).
/// NCBI TaxId: 1935942
/// </summary>
public abstract class Pseudomyxus : Mugilidae, IPseudomyxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudomyxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1935942;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudomyxus";

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
