using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Pseudemoia;

/// <summary>
/// Abstract class for Pseudemoia (genus).
/// NCBI TaxId: 223248
/// </summary>
public abstract class Pseudemoia : Scincidae, IPseudemoia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudemoia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223248;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudemoia";

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
