using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Adelastes;

/// <summary>
/// Abstract class for Adelastes (genus).
/// NCBI TaxId: 1658276
/// </summary>
public abstract class Adelastes : Microhylidae, IAdelastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adelastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1658276;

    /// <inheritdoc />
    public virtual string GenusName => "Adelastes";

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
