using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Caffrogobius;

/// <summary>
/// Abstract class for Caffrogobius (genus).
/// NCBI TaxId: 505232
/// </summary>
public abstract class Caffrogobius : Gobiidae, ICaffrogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caffrogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 505232;

    /// <inheritdoc />
    public virtual string GenusName => "Caffrogobius";

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
