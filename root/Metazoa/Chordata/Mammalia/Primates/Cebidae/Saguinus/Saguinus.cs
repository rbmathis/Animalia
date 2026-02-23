using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saguinus;

/// <summary>
/// Abstract class for Saguinus (genus).
/// NCBI TaxId: 9486
/// </summary>
public abstract class Saguinus : Cebidae, ISaguinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saguinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9486;

    /// <inheritdoc />
    public virtual string GenusName => "Saguinus";

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
