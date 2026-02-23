using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Corydon;

/// <summary>
/// Abstract class for Corydon (genus).
/// NCBI TaxId: 363776
/// </summary>
public abstract class Corydon : Eurylaimidae, ICorydon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corydon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 363776;

    /// <inheritdoc />
    public virtual string GenusName => "Corydon";

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
