using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chilodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chilodontidae.Chilodus;

/// <summary>
/// Abstract class for Chilodus (genus).
/// NCBI TaxId: 42620
/// </summary>
public abstract class Chilodus : Chilodontidae, IChilodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42620;

    /// <inheritdoc />
    public virtual string GenusName => "Chilodus";

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
