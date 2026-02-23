using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Sapajus;

/// <summary>
/// Abstract class for Sapajus (genus).
/// NCBI TaxId: 1532884
/// </summary>
public abstract class Sapajus : Cebidae, ISapajus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sapajus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1532884;

    /// <inheritdoc />
    public virtual string GenusName => "Sapajus";

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
