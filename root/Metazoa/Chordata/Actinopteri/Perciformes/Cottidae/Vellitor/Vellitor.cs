using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Vellitor;

/// <summary>
/// Abstract class for Vellitor (genus).
/// NCBI TaxId: 1802978
/// </summary>
public abstract class Vellitor : Cottidae, IVellitor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vellitor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1802978;

    /// <inheritdoc />
    public virtual string GenusName => "Vellitor";

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
