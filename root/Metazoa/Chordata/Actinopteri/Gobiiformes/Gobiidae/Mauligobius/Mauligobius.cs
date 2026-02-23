using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mauligobius;

/// <summary>
/// Abstract class for Mauligobius (genus).
/// NCBI TaxId: 1365695
/// </summary>
public abstract class Mauligobius : Gobiidae, IMauligobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mauligobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365695;

    /// <inheritdoc />
    public virtual string GenusName => "Mauligobius";

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
