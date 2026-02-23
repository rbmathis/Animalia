using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Vespadelus;

/// <summary>
/// Abstract class for Vespadelus (genus).
/// NCBI TaxId: 2689072
/// </summary>
public abstract class Vespadelus : Vespertilionidae, IVespadelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vespadelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2689072;

    /// <inheritdoc />
    public virtual string GenusName => "Vespadelus";

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
