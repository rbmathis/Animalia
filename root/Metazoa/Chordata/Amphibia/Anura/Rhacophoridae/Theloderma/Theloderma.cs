using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Theloderma;

/// <summary>
/// Abstract class for Theloderma (genus).
/// NCBI TaxId: 126965
/// </summary>
public abstract class Theloderma : Rhacophoridae, ITheloderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Theloderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126965;

    /// <inheritdoc />
    public virtual string GenusName => "Theloderma";

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
