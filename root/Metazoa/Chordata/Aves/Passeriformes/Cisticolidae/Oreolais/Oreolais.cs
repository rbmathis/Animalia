using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Oreolais;

/// <summary>
/// Abstract class for Oreolais (genus).
/// NCBI TaxId: 2038250
/// </summary>
public abstract class Oreolais : Cisticolidae, IOreolais
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreolais";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2038250;

    /// <inheritdoc />
    public virtual string GenusName => "Oreolais";

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
