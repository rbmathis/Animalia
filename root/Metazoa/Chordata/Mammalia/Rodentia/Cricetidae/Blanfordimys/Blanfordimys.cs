using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Blanfordimys;

/// <summary>
/// Abstract class for Blanfordimys (genus).
/// NCBI TaxId: 399228
/// </summary>
public abstract class Blanfordimys : Cricetidae, IBlanfordimys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blanfordimys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 399228;

    /// <inheritdoc />
    public virtual string GenusName => "Blanfordimys";

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
