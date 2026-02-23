using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Pseudophryne;

/// <summary>
/// Abstract class for Pseudophryne (genus).
/// NCBI TaxId: 30348
/// </summary>
public abstract class Pseudophryne : Myobatrachidae, IPseudophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30348;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudophryne";

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
