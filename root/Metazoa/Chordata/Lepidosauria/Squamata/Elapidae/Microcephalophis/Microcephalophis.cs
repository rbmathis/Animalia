using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Microcephalophis;

/// <summary>
/// Abstract class for Microcephalophis (genus).
/// NCBI TaxId: 3145177
/// </summary>
public abstract class Microcephalophis : Elapidae, IMicrocephalophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcephalophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3145177;

    /// <inheritdoc />
    public virtual string GenusName => "Microcephalophis";

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
