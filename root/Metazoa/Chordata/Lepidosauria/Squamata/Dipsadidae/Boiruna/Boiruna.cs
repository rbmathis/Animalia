using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Boiruna;

/// <summary>
/// Abstract class for Boiruna (genus).
/// NCBI TaxId: 666072
/// </summary>
public abstract class Boiruna : Dipsadidae, IBoiruna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boiruna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666072;

    /// <inheritdoc />
    public virtual string GenusName => "Boiruna";

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
