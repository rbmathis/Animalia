using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Caracanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Caracanthidae.Caracanthus;

/// <summary>
/// Abstract class for Caracanthus (genus).
/// NCBI TaxId: 274727
/// </summary>
public abstract class Caracanthus : Caracanthidae, ICaracanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caracanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274727;

    /// <inheritdoc />
    public virtual string GenusName => "Caracanthus";

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
