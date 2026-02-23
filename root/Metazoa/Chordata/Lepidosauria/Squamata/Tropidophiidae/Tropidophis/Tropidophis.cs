using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae.Tropidophis;

/// <summary>
/// Abstract class for Tropidophis (genus).
/// NCBI TaxId: 39246
/// </summary>
public abstract class Tropidophis : Tropidophiidae, ITropidophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropidophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39246;

    /// <inheritdoc />
    public virtual string GenusName => "Tropidophis";

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
