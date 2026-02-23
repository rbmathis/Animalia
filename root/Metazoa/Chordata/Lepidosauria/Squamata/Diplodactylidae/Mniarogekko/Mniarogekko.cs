using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Mniarogekko;

/// <summary>
/// Abstract class for Mniarogekko (genus).
/// NCBI TaxId: 1479062
/// </summary>
public abstract class Mniarogekko : Diplodactylidae, IMniarogekko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mniarogekko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1479062;

    /// <inheritdoc />
    public virtual string GenusName => "Mniarogekko";

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
