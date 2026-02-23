using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae.Ischnocnema;

/// <summary>
/// Abstract class for Ischnocnema (genus).
/// NCBI TaxId: 317360
/// </summary>
public abstract class Ischnocnema : Brachycephalidae, IIschnocnema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ischnocnema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317360;

    /// <inheritdoc />
    public virtual string GenusName => "Ischnocnema";

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
