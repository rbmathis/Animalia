using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Chondrodactylus;

/// <summary>
/// Abstract class for Chondrodactylus (genus).
/// NCBI TaxId: 202836
/// </summary>
public abstract class Chondrodactylus : Gekkonidae, IChondrodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chondrodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202836;

    /// <inheritdoc />
    public virtual string GenusName => "Chondrodactylus";

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
