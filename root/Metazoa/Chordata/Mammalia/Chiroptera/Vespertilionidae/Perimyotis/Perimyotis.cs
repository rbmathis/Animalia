using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Perimyotis;

/// <summary>
/// Abstract class for Perimyotis (genus).
/// NCBI TaxId: 2057181
/// </summary>
public abstract class Perimyotis : Vespertilionidae, IPerimyotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perimyotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2057181;

    /// <inheritdoc />
    public virtual string GenusName => "Perimyotis";

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
