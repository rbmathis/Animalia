using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Lycodonomorphus;

/// <summary>
/// Abstract class for Lycodonomorphus (genus).
/// NCBI TaxId: 382769
/// </summary>
public abstract class Lycodonomorphus : Lamprophiidae, ILycodonomorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycodonomorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 382769;

    /// <inheritdoc />
    public virtual string GenusName => "Lycodonomorphus";

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
