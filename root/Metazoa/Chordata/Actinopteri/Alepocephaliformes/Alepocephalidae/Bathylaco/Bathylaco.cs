using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Bathylaco;

/// <summary>
/// Abstract class for Bathylaco (genus).
/// NCBI TaxId: 466961
/// </summary>
public abstract class Bathylaco : Alepocephalidae, IBathylaco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathylaco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 466961;

    /// <inheritdoc />
    public virtual string GenusName => "Bathylaco";

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
