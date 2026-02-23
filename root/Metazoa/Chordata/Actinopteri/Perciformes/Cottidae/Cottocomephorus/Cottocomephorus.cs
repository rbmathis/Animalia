using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottocomephorus;

/// <summary>
/// Abstract class for Cottocomephorus (genus).
/// NCBI TaxId: 57733
/// </summary>
public abstract class Cottocomephorus : Cottidae, ICottocomephorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cottocomephorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57733;

    /// <inheritdoc />
    public virtual string GenusName => "Cottocomephorus";

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
