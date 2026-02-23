using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Hemistichodus;

/// <summary>
/// Abstract class for Hemistichodus (genus).
/// NCBI TaxId: 304015
/// </summary>
public abstract class Hemistichodus : Distichodontidae, IHemistichodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemistichodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304015;

    /// <inheritdoc />
    public virtual string GenusName => "Hemistichodus";

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
