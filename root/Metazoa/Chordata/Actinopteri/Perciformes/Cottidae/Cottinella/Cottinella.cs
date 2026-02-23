using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottinella;

/// <summary>
/// Abstract class for Cottinella (genus).
/// NCBI TaxId: 61638
/// </summary>
public abstract class Cottinella : Cottidae, ICottinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cottinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61638;

    /// <inheritdoc />
    public virtual string GenusName => "Cottinella";

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
