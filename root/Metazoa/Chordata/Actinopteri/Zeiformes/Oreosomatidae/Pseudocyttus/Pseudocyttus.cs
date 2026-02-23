using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Oreosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Oreosomatidae.Pseudocyttus;

/// <summary>
/// Abstract class for Pseudocyttus (genus).
/// NCBI TaxId: 244851
/// </summary>
public abstract class Pseudocyttus : Oreosomatidae, IPseudocyttus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocyttus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 244851;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocyttus";

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
