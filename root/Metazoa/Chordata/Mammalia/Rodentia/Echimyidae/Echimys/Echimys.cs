using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Echimys;

/// <summary>
/// Abstract class for Echimys (genus).
/// NCBI TaxId: 30620
/// </summary>
public abstract class Echimys : Echimyidae, IEchimys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echimys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30620;

    /// <inheritdoc />
    public virtual string GenusName => "Echimys";

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
