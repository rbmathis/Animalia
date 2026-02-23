using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Hylocryptus;

/// <summary>
/// Abstract class for Hylocryptus (genus).
/// NCBI TaxId: 329513
/// </summary>
public abstract class Hylocryptus : Furnariidae, IHylocryptus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylocryptus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329513;

    /// <inheritdoc />
    public virtual string GenusName => "Hylocryptus";

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
