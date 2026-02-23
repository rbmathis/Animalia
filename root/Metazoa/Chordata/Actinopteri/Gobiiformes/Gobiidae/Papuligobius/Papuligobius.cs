using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Papuligobius;

/// <summary>
/// Abstract class for Papuligobius (genus).
/// NCBI TaxId: 1365703
/// </summary>
public abstract class Papuligobius : Gobiidae, IPapuligobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Papuligobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365703;

    /// <inheritdoc />
    public virtual string GenusName => "Papuligobius";

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
