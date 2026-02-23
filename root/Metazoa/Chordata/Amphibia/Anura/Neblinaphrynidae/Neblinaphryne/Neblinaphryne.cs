using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Neblinaphrynidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Neblinaphrynidae.Neblinaphryne;

/// <summary>
/// Abstract class for Neblinaphryne (genus).
/// NCBI TaxId: 3149203
/// </summary>
public abstract class Neblinaphryne : Neblinaphrynidae, INeblinaphryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neblinaphryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3149203;

    /// <inheritdoc />
    public virtual string GenusName => "Neblinaphryne";

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
