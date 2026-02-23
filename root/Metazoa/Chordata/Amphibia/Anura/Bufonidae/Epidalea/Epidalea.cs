using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Epidalea;

/// <summary>
/// Abstract class for Epidalea (genus).
/// NCBI TaxId: 651674
/// </summary>
public abstract class Epidalea : Bufonidae, IEpidalea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epidalea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651674;

    /// <inheritdoc />
    public virtual string GenusName => "Epidalea";

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
