using AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Chelonia;

/// <summary>
/// Abstract class for Chelonia (genus).
/// NCBI TaxId: 8468
/// </summary>
public abstract class Chelonia : Cheloniidae, IChelonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8468;

    /// <inheritdoc />
    public virtual string GenusName => "Chelonia";

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
