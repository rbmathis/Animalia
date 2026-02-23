using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Neomixis;

/// <summary>
/// Abstract class for Neomixis (genus).
/// NCBI TaxId: 98134
/// </summary>
public abstract class Neomixis : Timaliidae, INeomixis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neomixis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98134;

    /// <inheritdoc />
    public virtual string GenusName => "Neomixis";

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
