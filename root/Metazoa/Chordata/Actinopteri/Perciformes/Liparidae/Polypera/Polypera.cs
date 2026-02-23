using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Polypera;

/// <summary>
/// Abstract class for Polypera (genus).
/// NCBI TaxId: 1562382
/// </summary>
public abstract class Polypera : Liparidae, IPolypera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polypera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1562382;

    /// <inheritdoc />
    public virtual string GenusName => "Polypera";

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
