using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Ramigekko;

/// <summary>
/// Abstract class for Ramigekko (genus).
/// NCBI TaxId: 1534313
/// </summary>
public abstract class Ramigekko : Gekkonidae, IRamigekko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramigekko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1534313;

    /// <inheritdoc />
    public virtual string GenusName => "Ramigekko";

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
