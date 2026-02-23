using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Arielulus;

/// <summary>
/// Abstract class for Arielulus (genus).
/// NCBI TaxId: 526815
/// </summary>
public abstract class Arielulus : Vespertilionidae, IArielulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arielulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 526815;

    /// <inheritdoc />
    public virtual string GenusName => "Arielulus";

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
