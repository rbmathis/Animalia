using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Cymbirhynchus;

/// <summary>
/// Abstract class for Cymbirhynchus (genus).
/// NCBI TaxId: 239372
/// </summary>
public abstract class Cymbirhynchus : Eurylaimidae, ICymbirhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cymbirhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 239372;

    /// <inheritdoc />
    public virtual string GenusName => "Cymbirhynchus";

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
