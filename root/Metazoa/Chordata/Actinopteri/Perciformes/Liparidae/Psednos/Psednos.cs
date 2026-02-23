using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Psednos;

/// <summary>
/// Abstract class for Psednos (genus).
/// NCBI TaxId: 446826
/// </summary>
public abstract class Psednos : Liparidae, IPsednos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psednos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446826;

    /// <inheritdoc />
    public virtual string GenusName => "Psednos";

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
