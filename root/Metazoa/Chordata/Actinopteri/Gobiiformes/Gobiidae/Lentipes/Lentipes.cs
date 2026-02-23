using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lentipes;

/// <summary>
/// Abstract class for Lentipes (genus).
/// NCBI TaxId: 70081
/// </summary>
public abstract class Lentipes : Gobiidae, ILentipes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lentipes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70081;

    /// <inheritdoc />
    public virtual string GenusName => "Lentipes";

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
