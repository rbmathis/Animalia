using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Aspasma;

/// <summary>
/// Abstract class for Aspasma (genus).
/// NCBI TaxId: 181475
/// </summary>
public abstract class Aspasma : Gobiesocidae, IAspasma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspasma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181475;

    /// <inheritdoc />
    public virtual string GenusName => "Aspasma";

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
