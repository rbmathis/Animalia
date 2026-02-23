using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Chrysuronia;

/// <summary>
/// Abstract class for Chrysuronia (genus).
/// NCBI TaxId: 304608
/// </summary>
public abstract class Chrysuronia : Trochilidae, IChrysuronia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysuronia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304608;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysuronia";

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
