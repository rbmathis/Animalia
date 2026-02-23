using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhipiduridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhipiduridae.Rhipidura;

/// <summary>
/// Abstract class for Rhipidura (genus).
/// NCBI TaxId: 107227
/// </summary>
public abstract class Rhipidura : Rhipiduridae, IRhipidura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhipidura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107227;

    /// <inheritdoc />
    public virtual string GenusName => "Rhipidura";

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
