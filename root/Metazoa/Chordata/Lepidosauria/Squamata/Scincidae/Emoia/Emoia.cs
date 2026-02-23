using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Emoia;

/// <summary>
/// Abstract class for Emoia (genus).
/// NCBI TaxId: 38242
/// </summary>
public abstract class Emoia : Scincidae, IEmoia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emoia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38242;

    /// <inheritdoc />
    public virtual string GenusName => "Emoia";

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
