using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Hamptophryne;

/// <summary>
/// Abstract class for Hamptophryne (genus).
/// NCBI TaxId: 143621
/// </summary>
public abstract class Hamptophryne : Microhylidae, IHamptophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hamptophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143621;

    /// <inheritdoc />
    public virtual string GenusName => "Hamptophryne";

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
