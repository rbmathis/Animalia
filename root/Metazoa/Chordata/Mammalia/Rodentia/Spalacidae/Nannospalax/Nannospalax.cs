using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Nannospalax;

/// <summary>
/// Abstract class for Nannospalax (genus).
/// NCBI TaxId: 30636
/// </summary>
public abstract class Nannospalax : Spalacidae, INannospalax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannospalax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30636;

    /// <inheritdoc />
    public virtual string GenusName => "Nannospalax";

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
