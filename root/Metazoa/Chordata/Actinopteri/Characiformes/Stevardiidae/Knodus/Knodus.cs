using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Knodus;

/// <summary>
/// Abstract class for Knodus (genus).
/// NCBI TaxId: 304043
/// </summary>
public abstract class Knodus : Stevardiidae, IKnodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Knodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304043;

    /// <inheritdoc />
    public virtual string GenusName => "Knodus";

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
