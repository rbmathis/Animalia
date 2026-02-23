using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Inyoka;

/// <summary>
/// Abstract class for Inyoka (genus).
/// NCBI TaxId: 1419112
/// </summary>
public abstract class Inyoka : Lamprophiidae, IInyoka
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Inyoka";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1419112;

    /// <inheritdoc />
    public virtual string GenusName => "Inyoka";

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
