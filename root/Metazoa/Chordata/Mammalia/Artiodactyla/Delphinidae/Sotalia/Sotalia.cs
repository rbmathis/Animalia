using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sotalia;

/// <summary>
/// Abstract class for Sotalia (genus).
/// NCBI TaxId: 103597
/// </summary>
public abstract class Sotalia : Delphinidae, ISotalia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sotalia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103597;

    /// <inheritdoc />
    public virtual string GenusName => "Sotalia";

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
