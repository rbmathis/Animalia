using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Holcosus;

/// <summary>
/// Abstract class for Holcosus (genus).
/// NCBI TaxId: 1382601
/// </summary>
public abstract class Holcosus : Teiidae, IHolcosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holcosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1382601;

    /// <inheritdoc />
    public virtual string GenusName => "Holcosus";

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
