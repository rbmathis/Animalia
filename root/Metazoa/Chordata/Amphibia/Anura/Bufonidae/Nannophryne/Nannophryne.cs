using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Nannophryne;

/// <summary>
/// Abstract class for Nannophryne (genus).
/// NCBI TaxId: 651675
/// </summary>
public abstract class Nannophryne : Bufonidae, INannophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651675;

    /// <inheritdoc />
    public virtual string GenusName => "Nannophryne";

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
