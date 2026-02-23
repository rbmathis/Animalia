using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Feihyla;

/// <summary>
/// Abstract class for Feihyla (genus).
/// NCBI TaxId: 670929
/// </summary>
public abstract class Feihyla : Rhacophoridae, IFeihyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Feihyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 670929;

    /// <inheritdoc />
    public virtual string GenusName => "Feihyla";

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
