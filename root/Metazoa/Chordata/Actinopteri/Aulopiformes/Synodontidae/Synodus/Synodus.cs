using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Synodus;

/// <summary>
/// Abstract class for Synodus (genus).
/// NCBI TaxId: 81391
/// </summary>
public abstract class Synodus : Synodontidae, ISynodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81391;

    /// <inheritdoc />
    public virtual string GenusName => "Synodus";

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
