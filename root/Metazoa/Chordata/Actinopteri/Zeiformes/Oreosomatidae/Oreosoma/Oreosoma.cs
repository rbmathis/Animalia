using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Oreosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Oreosomatidae.Oreosoma;

/// <summary>
/// Abstract class for Oreosoma (genus).
/// NCBI TaxId: 334980
/// </summary>
public abstract class Oreosoma : Oreosomatidae, IOreosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334980;

    /// <inheritdoc />
    public virtual string GenusName => "Oreosoma";

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
