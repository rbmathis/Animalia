using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Neobatrachus;

/// <summary>
/// Abstract class for Neobatrachus (genus).
/// NCBI TaxId: 43530
/// </summary>
public abstract class Neobatrachus : Limnodynastidae, INeobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43530;

    /// <inheritdoc />
    public virtual string GenusName => "Neobatrachus";

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
