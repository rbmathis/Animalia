using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Fejervarya;

/// <summary>
/// Abstract class for Fejervarya (genus).
/// NCBI TaxId: 127010
/// </summary>
public abstract class Fejervarya : Dicroglossidae, IFejervarya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fejervarya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 127010;

    /// <inheritdoc />
    public virtual string GenusName => "Fejervarya";

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
