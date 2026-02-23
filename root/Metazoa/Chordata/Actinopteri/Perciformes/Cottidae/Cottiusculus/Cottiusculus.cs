using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottiusculus;

/// <summary>
/// Abstract class for Cottiusculus (genus).
/// NCBI TaxId: 381886
/// </summary>
public abstract class Cottiusculus : Cottidae, ICottiusculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cottiusculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 381886;

    /// <inheritdoc />
    public virtual string GenusName => "Cottiusculus";

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
