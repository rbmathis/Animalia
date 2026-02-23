using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Feresa;

/// <summary>
/// Abstract class for Feresa (genus).
/// NCBI TaxId: 103591
/// </summary>
public abstract class Feresa : Delphinidae, IFeresa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Feresa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103591;

    /// <inheritdoc />
    public virtual string GenusName => "Feresa";

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
