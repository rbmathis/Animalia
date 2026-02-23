using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Setipinna;

/// <summary>
/// Abstract class for Setipinna (genus).
/// NCBI TaxId: 411568
/// </summary>
public abstract class Setipinna : Engraulidae, ISetipinna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Setipinna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 411568;

    /// <inheritdoc />
    public virtual string GenusName => "Setipinna";

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
