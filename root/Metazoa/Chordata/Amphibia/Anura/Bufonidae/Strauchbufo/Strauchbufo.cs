using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Strauchbufo;

/// <summary>
/// Abstract class for Strauchbufo (genus).
/// NCBI TaxId: 1909268
/// </summary>
public abstract class Strauchbufo : Bufonidae, IStrauchbufo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Strauchbufo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1909268;

    /// <inheritdoc />
    public virtual string GenusName => "Strauchbufo";

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
