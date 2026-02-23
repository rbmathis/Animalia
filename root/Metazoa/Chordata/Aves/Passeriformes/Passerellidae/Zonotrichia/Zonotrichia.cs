using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Zonotrichia;

/// <summary>
/// Abstract class for Zonotrichia (genus).
/// NCBI TaxId: 44387
/// </summary>
public abstract class Zonotrichia : Passerellidae, IZonotrichia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zonotrichia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44387;

    /// <inheritdoc />
    public virtual string GenusName => "Zonotrichia";

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
