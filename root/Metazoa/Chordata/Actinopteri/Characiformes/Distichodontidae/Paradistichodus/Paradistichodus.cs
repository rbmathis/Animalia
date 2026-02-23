using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Paradistichodus;

/// <summary>
/// Abstract class for Paradistichodus (genus).
/// NCBI TaxId: 1387215
/// </summary>
public abstract class Paradistichodus : Distichodontidae, IParadistichodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradistichodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1387215;

    /// <inheritdoc />
    public virtual string GenusName => "Paradistichodus";

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
