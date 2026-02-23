using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Schistolais;

/// <summary>
/// Abstract class for Schistolais (genus).
/// NCBI TaxId: 208063
/// </summary>
public abstract class Schistolais : Cisticolidae, ISchistolais
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schistolais";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208063;

    /// <inheritdoc />
    public virtual string GenusName => "Schistolais";

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
