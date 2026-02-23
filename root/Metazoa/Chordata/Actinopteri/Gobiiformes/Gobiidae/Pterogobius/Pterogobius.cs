using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pterogobius;

/// <summary>
/// Abstract class for Pterogobius (genus).
/// NCBI TaxId: 497282
/// </summary>
public abstract class Pterogobius : Gobiidae, IPterogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 497282;

    /// <inheritdoc />
    public virtual string GenusName => "Pterogobius";

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
