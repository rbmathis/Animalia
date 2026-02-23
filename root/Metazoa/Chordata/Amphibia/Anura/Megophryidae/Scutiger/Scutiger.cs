using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Scutiger;

/// <summary>
/// Abstract class for Scutiger (genus).
/// NCBI TaxId: 265034
/// </summary>
public abstract class Scutiger : Megophryidae, IScutiger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scutiger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 265034;

    /// <inheritdoc />
    public virtual string GenusName => "Scutiger";

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
