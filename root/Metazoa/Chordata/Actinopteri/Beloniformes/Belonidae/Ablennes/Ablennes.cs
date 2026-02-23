using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Ablennes;

/// <summary>
/// Abstract class for Ablennes (genus).
/// NCBI TaxId: 129034
/// </summary>
public abstract class Ablennes : Belonidae, IAblennes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ablennes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129034;

    /// <inheritdoc />
    public virtual string GenusName => "Ablennes";

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
