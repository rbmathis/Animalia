using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Histiotus;

/// <summary>
/// Abstract class for Histiotus (genus).
/// NCBI TaxId: 258918
/// </summary>
public abstract class Histiotus : Vespertilionidae, IHistiotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Histiotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 258918;

    /// <inheritdoc />
    public virtual string GenusName => "Histiotus";

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
