using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Crossarchus;

/// <summary>
/// Abstract class for Crossarchus (genus).
/// NCBI TaxId: 71110
/// </summary>
public abstract class Crossarchus : Herpestidae, ICrossarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crossarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71110;

    /// <inheritdoc />
    public virtual string GenusName => "Crossarchus";

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
