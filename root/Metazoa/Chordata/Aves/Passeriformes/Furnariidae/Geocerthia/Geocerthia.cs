using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Geocerthia;

/// <summary>
/// Abstract class for Geocerthia (genus).
/// NCBI TaxId: 2821482
/// </summary>
public abstract class Geocerthia : Furnariidae, IGeocerthia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geocerthia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821482;

    /// <inheritdoc />
    public virtual string GenusName => "Geocerthia";

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
