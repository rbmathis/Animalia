using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Polypedates;

/// <summary>
/// Abstract class for Polypedates (genus).
/// NCBI TaxId: 68448
/// </summary>
public abstract class Polypedates : Rhacophoridae, IPolypedates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polypedates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68448;

    /// <inheritdoc />
    public virtual string GenusName => "Polypedates";

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
