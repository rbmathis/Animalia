using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Oreophilais;

/// <summary>
/// Abstract class for Oreophilais (genus).
/// NCBI TaxId: 1306884
/// </summary>
public abstract class Oreophilais : Cisticolidae, IOreophilais
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreophilais";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1306884;

    /// <inheritdoc />
    public virtual string GenusName => "Oreophilais";

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
