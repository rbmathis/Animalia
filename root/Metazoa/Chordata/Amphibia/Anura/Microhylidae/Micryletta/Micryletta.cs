using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Micryletta;

/// <summary>
/// Abstract class for Micryletta (genus).
/// NCBI TaxId: 143627
/// </summary>
public abstract class Micryletta : Microhylidae, IMicryletta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micryletta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143627;

    /// <inheritdoc />
    public virtual string GenusName => "Micryletta";

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
