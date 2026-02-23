using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Ancylopsetta;

/// <summary>
/// Abstract class for Ancylopsetta (genus).
/// NCBI TaxId: 195593
/// </summary>
public abstract class Ancylopsetta : Paralichthyidae, IAncylopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ancylopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195593;

    /// <inheritdoc />
    public virtual string GenusName => "Ancylopsetta";

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
