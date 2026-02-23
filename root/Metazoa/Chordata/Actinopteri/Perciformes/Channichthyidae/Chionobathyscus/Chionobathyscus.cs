using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Chionobathyscus;

/// <summary>
/// Abstract class for Chionobathyscus (genus).
/// NCBI TaxId: 70441
/// </summary>
public abstract class Chionobathyscus : Channichthyidae, IChionobathyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chionobathyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70441;

    /// <inheritdoc />
    public virtual string GenusName => "Chionobathyscus";

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
