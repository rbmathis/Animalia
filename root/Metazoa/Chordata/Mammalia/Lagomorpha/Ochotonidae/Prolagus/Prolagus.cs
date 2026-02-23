using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Ochotonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Ochotonidae.Prolagus;

/// <summary>
/// Abstract class for Prolagus (genus).
/// NCBI TaxId: 3016545
/// </summary>
public abstract class Prolagus : Ochotonidae, IProlagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3016545;

    /// <inheritdoc />
    public virtual string GenusName => "Prolagus";

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
