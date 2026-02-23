using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Aphia;

/// <summary>
/// Abstract class for Aphia (genus).
/// NCBI TaxId: 441898
/// </summary>
public abstract class Aphia : Gobiidae, IAphia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 441898;

    /// <inheritdoc />
    public virtual string GenusName => "Aphia";

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
