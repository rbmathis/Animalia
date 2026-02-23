using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Schindleriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Schindleriidae.Schindleria;

/// <summary>
/// Abstract class for Schindleria (genus).
/// NCBI TaxId: 166781
/// </summary>
public abstract class Schindleria : Schindleriidae, ISchindleria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schindleria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166781;

    /// <inheritdoc />
    public virtual string GenusName => "Schindleria";

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
