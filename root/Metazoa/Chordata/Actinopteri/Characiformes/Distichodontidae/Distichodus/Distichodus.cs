using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Distichodus;

/// <summary>
/// Abstract class for Distichodus (genus).
/// NCBI TaxId: 42487
/// </summary>
public abstract class Distichodus : Distichodontidae, IDistichodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Distichodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42487;

    /// <inheritdoc />
    public virtual string GenusName => "Distichodus";

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
