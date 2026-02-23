using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Belonoperca;

/// <summary>
/// Abstract class for Belonoperca (genus).
/// NCBI TaxId: 327791
/// </summary>
public abstract class Belonoperca : Serranidae, IBelonoperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belonoperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327791;

    /// <inheritdoc />
    public virtual string GenusName => "Belonoperca";

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
