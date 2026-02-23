using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Oreosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Oreosomatidae.Allocyttus;

/// <summary>
/// Abstract class for Allocyttus (genus).
/// NCBI TaxId: 181444
/// </summary>
public abstract class Allocyttus : Oreosomatidae, IAllocyttus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allocyttus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181444;

    /// <inheritdoc />
    public virtual string GenusName => "Allocyttus";

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
