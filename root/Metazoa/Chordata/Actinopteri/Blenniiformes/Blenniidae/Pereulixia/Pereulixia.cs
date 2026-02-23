using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Pereulixia;

/// <summary>
/// Abstract class for Pereulixia (genus).
/// NCBI TaxId: 1405696
/// </summary>
public abstract class Pereulixia : Blenniidae, IPereulixia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pereulixia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1405696;

    /// <inheritdoc />
    public virtual string GenusName => "Pereulixia";

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
