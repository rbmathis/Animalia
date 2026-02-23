using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Boophis;

/// <summary>
/// Abstract class for Boophis (genus).
/// NCBI TaxId: 68425
/// </summary>
public abstract class Boophis : Mantellidae, IBoophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68425;

    /// <inheritdoc />
    public virtual string GenusName => "Boophis";

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
