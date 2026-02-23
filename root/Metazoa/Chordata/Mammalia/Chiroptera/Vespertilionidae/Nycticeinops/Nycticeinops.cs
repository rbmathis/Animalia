using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Nycticeinops;

/// <summary>
/// Abstract class for Nycticeinops (genus).
/// NCBI TaxId: 59468
/// </summary>
public abstract class Nycticeinops : Vespertilionidae, INycticeinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nycticeinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59468;

    /// <inheritdoc />
    public virtual string GenusName => "Nycticeinops";

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
