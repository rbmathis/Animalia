using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae.Grandisonia;

/// <summary>
/// Abstract class for Grandisonia (genus).
/// NCBI TaxId: 8447
/// </summary>
public abstract class Grandisonia : Indotyphlidae, IGrandisonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grandisonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8447;

    /// <inheritdoc />
    public virtual string GenusName => "Grandisonia";

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
