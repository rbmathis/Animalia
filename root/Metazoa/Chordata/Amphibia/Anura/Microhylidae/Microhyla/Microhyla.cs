using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

/// <summary>
/// Abstract class for Microhyla (genus).
/// NCBI TaxId: 129017
/// </summary>
public abstract class Microhyla : Microhylidae, IMicrohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microhyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129017;

    /// <inheritdoc />
    public virtual string GenusName => "Microhyla";

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
