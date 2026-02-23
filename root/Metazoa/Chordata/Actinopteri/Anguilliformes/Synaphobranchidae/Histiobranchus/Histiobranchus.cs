using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Histiobranchus;

/// <summary>
/// Abstract class for Histiobranchus (genus).
/// NCBI TaxId: 121286
/// </summary>
public abstract class Histiobranchus : Synaphobranchidae, IHistiobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Histiobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121286;

    /// <inheritdoc />
    public virtual string GenusName => "Histiobranchus";

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
