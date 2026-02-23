using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leimacomys;

/// <summary>
/// Abstract class for Leimacomys (genus).
/// NCBI TaxId: 3151848
/// </summary>
public abstract class Leimacomys : Muridae, ILeimacomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leimacomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3151848;

    /// <inheritdoc />
    public virtual string GenusName => "Leimacomys";

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
