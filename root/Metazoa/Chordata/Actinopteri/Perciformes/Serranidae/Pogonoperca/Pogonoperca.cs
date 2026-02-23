using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Pogonoperca;

/// <summary>
/// Abstract class for Pogonoperca (genus).
/// NCBI TaxId: 160737
/// </summary>
public abstract class Pogonoperca : Serranidae, IPogonoperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pogonoperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 160737;

    /// <inheritdoc />
    public virtual string GenusName => "Pogonoperca";

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
