using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Randia;

/// <summary>
/// Abstract class for Randia (genus).
/// NCBI TaxId: 1743363
/// </summary>
public abstract class Randia : Bernieridae, IRandia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Randia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1743363;

    /// <inheritdoc />
    public virtual string GenusName => "Randia";

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
