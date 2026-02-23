using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Dactylomys;

/// <summary>
/// Abstract class for Dactylomys (genus).
/// NCBI TaxId: 30617
/// </summary>
public abstract class Dactylomys : Echimyidae, IDactylomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dactylomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30617;

    /// <inheritdoc />
    public virtual string GenusName => "Dactylomys";

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
