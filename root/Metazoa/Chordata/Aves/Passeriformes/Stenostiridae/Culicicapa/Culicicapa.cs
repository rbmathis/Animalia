using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Stenostiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Stenostiridae.Culicicapa;

/// <summary>
/// Abstract class for Culicicapa (genus).
/// NCBI TaxId: 107202
/// </summary>
public abstract class Culicicapa : Stenostiridae, ICulicicapa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Culicicapa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107202;

    /// <inheritdoc />
    public virtual string GenusName => "Culicicapa";

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
