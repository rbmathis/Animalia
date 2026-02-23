using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Neoromicia;

/// <summary>
/// Abstract class for Neoromicia (genus).
/// NCBI TaxId: 568926
/// </summary>
public abstract class Neoromicia : Vespertilionidae, INeoromicia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoromicia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 568926;

    /// <inheritdoc />
    public virtual string GenusName => "Neoromicia";

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
