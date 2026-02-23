using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Dendrocitta;

/// <summary>
/// Abstract class for Dendrocitta (genus).
/// NCBI TaxId: 257852
/// </summary>
public abstract class Dendrocitta : Corvidae, IDendrocitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrocitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 257852;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrocitta";

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
