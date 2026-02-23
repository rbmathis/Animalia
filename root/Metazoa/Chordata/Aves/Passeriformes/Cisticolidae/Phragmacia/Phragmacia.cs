using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Phragmacia;

/// <summary>
/// Abstract class for Phragmacia (genus).
/// NCBI TaxId: 1306886
/// </summary>
public abstract class Phragmacia : Cisticolidae, IPhragmacia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phragmacia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1306886;

    /// <inheritdoc />
    public virtual string GenusName => "Phragmacia";

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
