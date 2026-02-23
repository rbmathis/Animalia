using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Gymnoscopelus;

/// <summary>
/// Abstract class for Gymnoscopelus (genus).
/// NCBI TaxId: 123324
/// </summary>
public abstract class Gymnoscopelus : Myctophidae, IGymnoscopelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnoscopelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123324;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnoscopelus";

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
