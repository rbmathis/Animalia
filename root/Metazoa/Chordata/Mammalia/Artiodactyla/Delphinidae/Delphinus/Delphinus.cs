using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Delphinus;

/// <summary>
/// Abstract class for Delphinus (genus).
/// NCBI TaxId: 9727
/// </summary>
public abstract class Delphinus : Delphinidae, IDelphinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Delphinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9727;

    /// <inheritdoc />
    public virtual string GenusName => "Delphinus";

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
