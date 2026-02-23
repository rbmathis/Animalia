using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Luperosaurus;

/// <summary>
/// Abstract class for Luperosaurus (genus).
/// NCBI TaxId: 1183068
/// </summary>
public abstract class Luperosaurus : Gekkonidae, ILuperosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luperosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1183068;

    /// <inheritdoc />
    public virtual string GenusName => "Luperosaurus";

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
