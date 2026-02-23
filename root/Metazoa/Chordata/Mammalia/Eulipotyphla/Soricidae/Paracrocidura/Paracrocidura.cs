using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Paracrocidura;

/// <summary>
/// Abstract class for Paracrocidura (genus).
/// NCBI TaxId: 148966
/// </summary>
public abstract class Paracrocidura : Soricidae, IParacrocidura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracrocidura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148966;

    /// <inheritdoc />
    public virtual string GenusName => "Paracrocidura";

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
