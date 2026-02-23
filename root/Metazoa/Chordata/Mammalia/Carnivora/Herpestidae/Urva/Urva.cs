using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Urva;

/// <summary>
/// Abstract class for Urva (genus).
/// NCBI TaxId: 2079297
/// </summary>
public abstract class Urva : Herpestidae, IUrva
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urva";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2079297;

    /// <inheritdoc />
    public virtual string GenusName => "Urva";

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
