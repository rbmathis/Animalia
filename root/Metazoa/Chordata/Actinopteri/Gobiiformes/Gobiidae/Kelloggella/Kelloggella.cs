using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Kelloggella;

/// <summary>
/// Abstract class for Kelloggella (genus).
/// NCBI TaxId: 1916797
/// </summary>
public abstract class Kelloggella : Gobiidae, IKelloggella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kelloggella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1916797;

    /// <inheritdoc />
    public virtual string GenusName => "Kelloggella";

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
