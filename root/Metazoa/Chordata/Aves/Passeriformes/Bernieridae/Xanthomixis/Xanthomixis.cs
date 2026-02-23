using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Xanthomixis;

/// <summary>
/// Abstract class for Xanthomixis (genus).
/// NCBI TaxId: 374661
/// </summary>
public abstract class Xanthomixis : Bernieridae, IXanthomixis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xanthomixis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374661;

    /// <inheritdoc />
    public virtual string GenusName => "Xanthomixis";

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
