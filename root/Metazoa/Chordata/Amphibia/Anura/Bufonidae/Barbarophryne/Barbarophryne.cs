using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Barbarophryne;

/// <summary>
/// Abstract class for Barbarophryne (genus).
/// NCBI TaxId: 1720405
/// </summary>
public abstract class Barbarophryne : Bufonidae, IBarbarophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbarophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1720405;

    /// <inheritdoc />
    public virtual string GenusName => "Barbarophryne";

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
