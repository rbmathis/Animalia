using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sagmatias;

/// <summary>
/// Abstract class for Sagmatias (genus).
/// NCBI TaxId: 3371042
/// </summary>
public abstract class Sagmatias : Delphinidae, ISagmatias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sagmatias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371042;

    /// <inheritdoc />
    public virtual string GenusName => "Sagmatias";

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
