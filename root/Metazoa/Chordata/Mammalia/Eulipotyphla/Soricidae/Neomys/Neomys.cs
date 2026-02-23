using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Neomys;

/// <summary>
/// Abstract class for Neomys (genus).
/// NCBI TaxId: 52813
/// </summary>
public abstract class Neomys : Soricidae, INeomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52813;

    /// <inheritdoc />
    public virtual string GenusName => "Neomys";

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
