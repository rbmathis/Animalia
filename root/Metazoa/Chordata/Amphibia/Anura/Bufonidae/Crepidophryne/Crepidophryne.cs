using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Crepidophryne;

/// <summary>
/// Abstract class for Crepidophryne (genus).
/// NCBI TaxId: 1008458
/// </summary>
public abstract class Crepidophryne : Bufonidae, ICrepidophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crepidophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1008458;

    /// <inheritdoc />
    public virtual string GenusName => "Crepidophryne";

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
