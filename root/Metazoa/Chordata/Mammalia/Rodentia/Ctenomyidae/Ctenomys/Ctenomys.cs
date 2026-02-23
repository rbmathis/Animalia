using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenomyidae.Ctenomys;

/// <summary>
/// Abstract class for Ctenomys (genus).
/// NCBI TaxId: 33551
/// </summary>
public abstract class Ctenomys : Ctenomyidae, ICtenomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33551;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenomys";

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
