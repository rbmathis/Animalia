using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Schismaderma;

/// <summary>
/// Abstract class for Schismaderma (genus).
/// NCBI TaxId: 47587
/// </summary>
public abstract class Schismaderma : Bufonidae, ISchismaderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schismaderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47587;

    /// <inheritdoc />
    public virtual string GenusName => "Schismaderma";

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
