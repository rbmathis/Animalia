using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Holbrookia;

/// <summary>
/// Abstract class for Holbrookia (genus).
/// NCBI TaxId: 43596
/// </summary>
public abstract class Holbrookia : Phrynosomatidae, IHolbrookia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holbrookia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43596;

    /// <inheritdoc />
    public virtual string GenusName => "Holbrookia";

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
