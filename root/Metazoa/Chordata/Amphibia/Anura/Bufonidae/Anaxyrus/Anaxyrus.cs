using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Anaxyrus;

/// <summary>
/// Abstract class for Anaxyrus (genus).
/// NCBI TaxId: 651670
/// </summary>
public abstract class Anaxyrus : Bufonidae, IAnaxyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anaxyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651670;

    /// <inheritdoc />
    public virtual string GenusName => "Anaxyrus";

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
