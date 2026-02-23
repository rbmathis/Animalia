using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Leptopelis;

/// <summary>
/// Abstract class for Leptopelis (genus).
/// NCBI TaxId: 39601
/// </summary>
public abstract class Leptopelis : Arthroleptidae, ILeptopelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptopelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39601;

    /// <inheritdoc />
    public virtual string GenusName => "Leptopelis";

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
