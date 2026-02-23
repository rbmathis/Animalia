using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobulus;

/// <summary>
/// Abstract class for Gobulus (genus).
/// NCBI TaxId: 203317
/// </summary>
public abstract class Gobulus : Gobiidae, IGobulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203317;

    /// <inheritdoc />
    public virtual string GenusName => "Gobulus";

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
