using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae.Dolloidraco;

/// <summary>
/// Abstract class for Dolloidraco (genus).
/// NCBI TaxId: 202057
/// </summary>
public abstract class Dolloidraco : Artedidraconidae, IDolloidraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dolloidraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202057;

    /// <inheritdoc />
    public virtual string GenusName => "Dolloidraco";

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
