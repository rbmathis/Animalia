using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Bromeliohyla;

/// <summary>
/// Abstract class for Bromeliohyla (genus).
/// NCBI TaxId: 374079
/// </summary>
public abstract class Bromeliohyla : Hylidae, IBromeliohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bromeliohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374079;

    /// <inheritdoc />
    public virtual string GenusName => "Bromeliohyla";

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
