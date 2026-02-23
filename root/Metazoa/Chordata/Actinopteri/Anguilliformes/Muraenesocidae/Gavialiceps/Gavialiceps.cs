using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae.Gavialiceps;

/// <summary>
/// Abstract class for Gavialiceps (genus).
/// NCBI TaxId: 189500
/// </summary>
public abstract class Gavialiceps : Muraenesocidae, IGavialiceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gavialiceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189500;

    /// <inheritdoc />
    public virtual string GenusName => "Gavialiceps";

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
