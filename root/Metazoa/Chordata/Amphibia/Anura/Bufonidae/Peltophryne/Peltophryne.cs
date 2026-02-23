using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Peltophryne;

/// <summary>
/// Abstract class for Peltophryne (genus).
/// NCBI TaxId: 651678
/// </summary>
public abstract class Peltophryne : Bufonidae, IPeltophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peltophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651678;

    /// <inheritdoc />
    public virtual string GenusName => "Peltophryne";

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
