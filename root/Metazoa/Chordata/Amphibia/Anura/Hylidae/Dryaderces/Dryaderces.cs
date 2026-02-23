using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Dryaderces;

/// <summary>
/// Abstract class for Dryaderces (genus).
/// NCBI TaxId: 2728970
/// </summary>
public abstract class Dryaderces : Hylidae, IDryaderces
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dryaderces";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2728970;

    /// <inheritdoc />
    public virtual string GenusName => "Dryaderces";

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
