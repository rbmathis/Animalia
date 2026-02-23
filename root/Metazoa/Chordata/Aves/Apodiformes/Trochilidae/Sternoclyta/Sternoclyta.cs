using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Sternoclyta;

/// <summary>
/// Abstract class for Sternoclyta (genus).
/// NCBI TaxId: 2744921
/// </summary>
public abstract class Sternoclyta : Trochilidae, ISternoclyta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sternoclyta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2744921;

    /// <inheritdoc />
    public virtual string GenusName => "Sternoclyta";

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
