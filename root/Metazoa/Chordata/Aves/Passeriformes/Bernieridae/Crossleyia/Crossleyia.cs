using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Crossleyia;

/// <summary>
/// Abstract class for Crossleyia (genus).
/// NCBI TaxId: 147063
/// </summary>
public abstract class Crossleyia : Bernieridae, ICrossleyia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crossleyia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 147063;

    /// <inheritdoc />
    public virtual string GenusName => "Crossleyia";

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
