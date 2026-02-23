using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Petauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Petauridae.Dactylopsila;

/// <summary>
/// Abstract class for Dactylopsila (genus).
/// NCBI TaxId: 38615
/// </summary>
public abstract class Dactylopsila : Petauridae, IDactylopsila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dactylopsila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38615;

    /// <inheritdoc />
    public virtual string GenusName => "Dactylopsila";

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
