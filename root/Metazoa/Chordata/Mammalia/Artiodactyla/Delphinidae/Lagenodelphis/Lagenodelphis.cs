using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Lagenodelphis;

/// <summary>
/// Abstract class for Lagenodelphis (genus).
/// NCBI TaxId: 103593
/// </summary>
public abstract class Lagenodelphis : Delphinidae, ILagenodelphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagenodelphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103593;

    /// <inheritdoc />
    public virtual string GenusName => "Lagenodelphis";

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
