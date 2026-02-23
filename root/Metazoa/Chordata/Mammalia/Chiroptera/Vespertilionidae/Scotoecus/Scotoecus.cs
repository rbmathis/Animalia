using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Scotoecus;

/// <summary>
/// Abstract class for Scotoecus (genus).
/// NCBI TaxId: 258954
/// </summary>
public abstract class Scotoecus : Vespertilionidae, IScotoecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scotoecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 258954;

    /// <inheritdoc />
    public virtual string GenusName => "Scotoecus";

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
