using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Leptolalax;

/// <summary>
/// Abstract class for Leptolalax (genus).
/// NCBI TaxId: 161699
/// </summary>
public abstract class Leptolalax : Megophryidae, ILeptolalax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptolalax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161699;

    /// <inheritdoc />
    public virtual string GenusName => "Leptolalax";

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
