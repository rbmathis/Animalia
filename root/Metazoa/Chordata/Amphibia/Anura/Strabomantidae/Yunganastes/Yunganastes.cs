using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Yunganastes;

/// <summary>
/// Abstract class for Yunganastes (genus).
/// NCBI TaxId: 651460
/// </summary>
public abstract class Yunganastes : Strabomantidae, IYunganastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yunganastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651460;

    /// <inheritdoc />
    public virtual string GenusName => "Yunganastes";

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
