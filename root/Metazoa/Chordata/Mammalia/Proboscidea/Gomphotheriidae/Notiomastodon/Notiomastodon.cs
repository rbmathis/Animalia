using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Gomphotheriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Gomphotheriidae.Notiomastodon;

/// <summary>
/// Abstract class for Notiomastodon (genus).
/// NCBI TaxId: 2885231
/// </summary>
public abstract class Notiomastodon : Gomphotheriidae, INotiomastodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notiomastodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2885231;

    /// <inheritdoc />
    public virtual string GenusName => "Notiomastodon";

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
