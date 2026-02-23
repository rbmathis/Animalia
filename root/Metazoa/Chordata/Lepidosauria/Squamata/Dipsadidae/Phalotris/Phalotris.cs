using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Phalotris;

/// <summary>
/// Abstract class for Phalotris (genus).
/// NCBI TaxId: 666097
/// </summary>
public abstract class Phalotris : Dipsadidae, IPhalotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phalotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666097;

    /// <inheritdoc />
    public virtual string GenusName => "Phalotris";

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
