using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Dendragapus;

/// <summary>
/// Abstract class for Dendragapus (genus).
/// NCBI TaxId: 90754
/// </summary>
public abstract class Dendragapus : Phasianidae, IDendragapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendragapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 90754;

    /// <inheritdoc />
    public virtual string GenusName => "Dendragapus";

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
