using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Pristurus;

/// <summary>
/// Abstract class for Pristurus (genus).
/// NCBI TaxId: 401533
/// </summary>
public abstract class Pristurus : Sphaerodactylidae, IPristurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 401533;

    /// <inheritdoc />
    public virtual string GenusName => "Pristurus";

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
