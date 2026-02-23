using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae.Breitensteinia;

/// <summary>
/// Abstract class for Breitensteinia (genus).
/// NCBI TaxId: 385277
/// </summary>
public abstract class Breitensteinia : Akysidae, IBreitensteinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Breitensteinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385277;

    /// <inheritdoc />
    public virtual string GenusName => "Breitensteinia";

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
