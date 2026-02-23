using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Dasypodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Dasypodidae.Dasypus;

/// <summary>
/// Abstract class for Dasypus (genus).
/// NCBI TaxId: 9360
/// </summary>
public abstract class Dasypus : Dasypodidae, IDasypus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasypus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9360;

    /// <inheritdoc />
    public virtual string GenusName => "Dasypus";

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
