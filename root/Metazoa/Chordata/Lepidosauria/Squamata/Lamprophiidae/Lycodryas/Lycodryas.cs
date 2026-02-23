using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Lycodryas;

/// <summary>
/// Abstract class for Lycodryas (genus).
/// NCBI TaxId: 292840
/// </summary>
public abstract class Lycodryas : Lamprophiidae, ILycodryas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycodryas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292840;

    /// <inheritdoc />
    public virtual string GenusName => "Lycodryas";

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
