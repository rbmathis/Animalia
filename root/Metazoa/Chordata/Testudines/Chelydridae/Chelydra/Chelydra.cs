using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelydridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelydridae.Chelydra;

/// <summary>
/// Abstract class for Chelydra (genus).
/// NCBI TaxId: 8474
/// </summary>
public abstract class Chelydra : Chelydridae, IChelydra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelydra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8474;

    /// <inheritdoc />
    public virtual string GenusName => "Chelydra";

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
