using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Sooglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Sooglossidae.Sechellophryne;

/// <summary>
/// Abstract class for Sechellophryne (genus).
/// NCBI TaxId: 932624
/// </summary>
public abstract class Sechellophryne : Sooglossidae, ISechellophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sechellophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 932624;

    /// <inheritdoc />
    public virtual string GenusName => "Sechellophryne";

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
