using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Bero;

/// <summary>
/// Abstract class for Bero (genus).
/// NCBI TaxId: 1633512
/// </summary>
public abstract class Bero : Cottidae, IBero
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bero";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633512;

    /// <inheritdoc />
    public virtual string GenusName => "Bero";

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
