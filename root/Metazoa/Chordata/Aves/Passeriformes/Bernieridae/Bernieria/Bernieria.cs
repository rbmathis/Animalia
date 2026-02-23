using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Bernieria;

/// <summary>
/// Abstract class for Bernieria (genus).
/// NCBI TaxId: 374659
/// </summary>
public abstract class Bernieria : Bernieridae, IBernieria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bernieria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374659;

    /// <inheritdoc />
    public virtual string GenusName => "Bernieria";

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
