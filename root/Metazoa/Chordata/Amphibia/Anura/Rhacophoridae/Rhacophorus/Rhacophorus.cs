using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Rhacophorus;

/// <summary>
/// Abstract class for Rhacophorus (genus).
/// NCBI TaxId: 27578
/// </summary>
public abstract class Rhacophorus : Rhacophoridae, IRhacophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhacophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27578;

    /// <inheritdoc />
    public virtual string GenusName => "Rhacophorus";

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
