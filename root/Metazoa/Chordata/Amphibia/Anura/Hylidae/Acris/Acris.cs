using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Acris;

/// <summary>
/// Abstract class for Acris (genus).
/// NCBI TaxId: 317299
/// </summary>
public abstract class Acris : Hylidae, IAcris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317299;

    /// <inheritdoc />
    public virtual string GenusName => "Acris";

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
