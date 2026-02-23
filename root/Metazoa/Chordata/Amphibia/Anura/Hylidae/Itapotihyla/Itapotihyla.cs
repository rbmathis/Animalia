using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Itapotihyla;

/// <summary>
/// Abstract class for Itapotihyla (genus).
/// NCBI TaxId: 374086
/// </summary>
public abstract class Itapotihyla : Hylidae, IItapotihyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Itapotihyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374086;

    /// <inheritdoc />
    public virtual string GenusName => "Itapotihyla";

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
