using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Chatogekko;

/// <summary>
/// Abstract class for Chatogekko (genus).
/// NCBI TaxId: 1118231
/// </summary>
public abstract class Chatogekko : Sphaerodactylidae, IChatogekko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chatogekko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118231;

    /// <inheritdoc />
    public virtual string GenusName => "Chatogekko";

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
