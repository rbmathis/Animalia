using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Luciosoma;

/// <summary>
/// Abstract class for Luciosoma (genus).
/// NCBI TaxId: 432414
/// </summary>
public abstract class Luciosoma : Danionidae, ILuciosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luciosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432414;

    /// <inheritdoc />
    public virtual string GenusName => "Luciosoma";

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
