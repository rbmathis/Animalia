using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Liopholidophis;

/// <summary>
/// Abstract class for Liopholidophis (genus).
/// NCBI TaxId: 143663
/// </summary>
public abstract class Liopholidophis : Lamprophiidae, ILiopholidophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liopholidophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143663;

    /// <inheritdoc />
    public virtual string GenusName => "Liopholidophis";

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
