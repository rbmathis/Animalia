using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cryptactites;

/// <summary>
/// Abstract class for Cryptactites (genus).
/// NCBI TaxId: 401527
/// </summary>
public abstract class Cryptactites : Gekkonidae, ICryptactites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptactites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 401527;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptactites";

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
