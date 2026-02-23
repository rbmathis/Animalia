using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Paedophryne;

/// <summary>
/// Abstract class for Paedophryne (genus).
/// NCBI TaxId: 1075805
/// </summary>
public abstract class Paedophryne : Microhylidae, IPaedophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paedophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1075805;

    /// <inheritdoc />
    public virtual string GenusName => "Paedophryne";

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
