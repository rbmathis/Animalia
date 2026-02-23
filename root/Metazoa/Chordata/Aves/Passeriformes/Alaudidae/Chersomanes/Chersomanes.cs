using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Chersomanes;

/// <summary>
/// Abstract class for Chersomanes (genus).
/// NCBI TaxId: 552894
/// </summary>
public abstract class Chersomanes : Alaudidae, IChersomanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chersomanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 552894;

    /// <inheritdoc />
    public virtual string GenusName => "Chersomanes";

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
