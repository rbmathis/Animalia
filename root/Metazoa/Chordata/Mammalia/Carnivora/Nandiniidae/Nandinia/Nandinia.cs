using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Nandiniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Nandiniidae.Nandinia;

/// <summary>
/// Abstract class for Nandinia (genus).
/// NCBI TaxId: 71114
/// </summary>
public abstract class Nandinia : Nandiniidae, INandinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nandinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71114;

    /// <inheritdoc />
    public virtual string GenusName => "Nandinia";

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
