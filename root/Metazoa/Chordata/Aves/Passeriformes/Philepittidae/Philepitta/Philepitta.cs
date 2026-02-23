using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Philepittidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Philepittidae.Philepitta;

/// <summary>
/// Abstract class for Philepitta (genus).
/// NCBI TaxId: 137531
/// </summary>
public abstract class Philepitta : Philepittidae, IPhilepitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philepitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137531;

    /// <inheritdoc />
    public virtual string GenusName => "Philepitta";

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
