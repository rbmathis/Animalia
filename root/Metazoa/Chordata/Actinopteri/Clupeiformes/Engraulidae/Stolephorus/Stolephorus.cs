using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Stolephorus;

/// <summary>
/// Abstract class for Stolephorus (genus).
/// NCBI TaxId: 365057
/// </summary>
public abstract class Stolephorus : Engraulidae, IStolephorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stolephorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 365057;

    /// <inheritdoc />
    public virtual string GenusName => "Stolephorus";

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
