using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Epictia;

/// <summary>
/// Abstract class for Epictia (genus).
/// NCBI TaxId: 711059
/// </summary>
public abstract class Epictia : Leptotyphlopidae, IEpictia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epictia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 711059;

    /// <inheritdoc />
    public virtual string GenusName => "Epictia";

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
