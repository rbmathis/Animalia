using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Tupinambis;

/// <summary>
/// Abstract class for Tupinambis (genus).
/// NCBI TaxId: 8531
/// </summary>
public abstract class Tupinambis : Teiidae, ITupinambis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tupinambis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8531;

    /// <inheritdoc />
    public virtual string GenusName => "Tupinambis";

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
