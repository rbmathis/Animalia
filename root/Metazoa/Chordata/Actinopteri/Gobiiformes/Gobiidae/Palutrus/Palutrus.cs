using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Palutrus;

/// <summary>
/// Abstract class for Palutrus (genus).
/// NCBI TaxId: 2589341
/// </summary>
public abstract class Palutrus : Gobiidae, IPalutrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Palutrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2589341;

    /// <inheritdoc />
    public virtual string GenusName => "Palutrus";

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
