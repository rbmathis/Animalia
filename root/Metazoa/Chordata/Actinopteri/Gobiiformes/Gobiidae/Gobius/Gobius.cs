using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobius;

/// <summary>
/// Abstract class for Gobius (genus).
/// NCBI TaxId: 45204
/// </summary>
public abstract class Gobius : Gobiidae, IGobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45204;

    /// <inheritdoc />
    public virtual string GenusName => "Gobius";

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
