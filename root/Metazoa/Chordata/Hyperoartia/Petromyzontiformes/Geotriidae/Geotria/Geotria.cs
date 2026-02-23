using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Geotriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Geotriidae.Geotria;

/// <summary>
/// Abstract class for Geotria (genus).
/// NCBI TaxId: 71167
/// </summary>
public abstract class Geotria : Geotriidae, IGeotria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geotria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71167;

    /// <inheritdoc />
    public virtual string GenusName => "Geotria";

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
