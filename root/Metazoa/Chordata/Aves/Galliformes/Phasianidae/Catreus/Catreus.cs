using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Catreus;

/// <summary>
/// Abstract class for Catreus (genus).
/// NCBI TaxId: 9084
/// </summary>
public abstract class Catreus : Phasianidae, ICatreus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catreus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9084;

    /// <inheritdoc />
    public virtual string GenusName => "Catreus";

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
