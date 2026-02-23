using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Achiropsetta;

/// <summary>
/// Abstract class for Achiropsetta (genus).
/// NCBI TaxId: 443794
/// </summary>
public abstract class Achiropsetta : Rhombosoleidae, IAchiropsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Achiropsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443794;

    /// <inheritdoc />
    public virtual string GenusName => "Achiropsetta";

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
