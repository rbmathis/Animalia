using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Firouzophrynus;

/// <summary>
/// Abstract class for Firouzophrynus (genus).
/// NCBI TaxId: 3458483
/// </summary>
public abstract class Firouzophrynus : Bufonidae, IFirouzophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Firouzophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3458483;

    /// <inheritdoc />
    public virtual string GenusName => "Firouzophrynus";

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
