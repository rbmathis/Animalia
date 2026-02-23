using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eucyclogobius;

/// <summary>
/// Abstract class for Eucyclogobius (genus).
/// NCBI TaxId: 166744
/// </summary>
public abstract class Eucyclogobius : Gobiidae, IEucyclogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eucyclogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166744;

    /// <inheritdoc />
    public virtual string GenusName => "Eucyclogobius";

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
