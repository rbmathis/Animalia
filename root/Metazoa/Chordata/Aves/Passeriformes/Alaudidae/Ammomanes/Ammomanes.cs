using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Ammomanes;

/// <summary>
/// Abstract class for Ammomanes (genus).
/// NCBI TaxId: 215303
/// </summary>
public abstract class Ammomanes : Alaudidae, IAmmomanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammomanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215303;

    /// <inheritdoc />
    public virtual string GenusName => "Ammomanes";

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
