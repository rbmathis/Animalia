using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Monostichodus;

/// <summary>
/// Abstract class for Monostichodus (genus).
/// NCBI TaxId: 3362334
/// </summary>
public abstract class Monostichodus : Distichodontidae, IMonostichodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monostichodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362334;

    /// <inheritdoc />
    public virtual string GenusName => "Monostichodus";

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
