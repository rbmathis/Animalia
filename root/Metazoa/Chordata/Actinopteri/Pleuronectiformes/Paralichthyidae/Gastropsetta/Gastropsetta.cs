using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Gastropsetta;

/// <summary>
/// Abstract class for Gastropsetta (genus).
/// NCBI TaxId: 1311549
/// </summary>
public abstract class Gastropsetta : Paralichthyidae, IGastropsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gastropsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311549;

    /// <inheritdoc />
    public virtual string GenusName => "Gastropsetta";

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
