using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Chondestes;

/// <summary>
/// Abstract class for Chondestes (genus).
/// NCBI TaxId: 158615
/// </summary>
public abstract class Chondestes : Passerellidae, IChondestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chondestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158615;

    /// <inheritdoc />
    public virtual string GenusName => "Chondestes";

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
