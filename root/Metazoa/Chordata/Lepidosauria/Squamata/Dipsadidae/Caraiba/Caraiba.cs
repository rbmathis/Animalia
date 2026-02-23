using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Caraiba;

/// <summary>
/// Abstract class for Caraiba (genus).
/// NCBI TaxId: 1335311
/// </summary>
public abstract class Caraiba : Dipsadidae, ICaraiba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caraiba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1335311;

    /// <inheritdoc />
    public virtual string GenusName => "Caraiba";

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
