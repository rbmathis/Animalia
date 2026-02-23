using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Micrelaps;

/// <summary>
/// Abstract class for Micrelaps (genus).
/// NCBI TaxId: 382775
/// </summary>
public abstract class Micrelaps : Lamprophiidae, IMicrelaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micrelaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 382775;

    /// <inheritdoc />
    public virtual string GenusName => "Micrelaps";

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
