using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Oreosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Oreosomatidae.Neocyttus;

/// <summary>
/// Abstract class for Neocyttus (genus).
/// NCBI TaxId: 181446
/// </summary>
public abstract class Neocyttus : Oreosomatidae, INeocyttus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neocyttus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181446;

    /// <inheritdoc />
    public virtual string GenusName => "Neocyttus";

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
